using System.Collections.Generic;
using System.Linq;
using ST.Models.Entities;
using ST.DAL;
using ST.Models.ViewModels;
using System;

namespace ST.BLL.Repository
{
    public class AdresRepo : RepositoryBase<Adres, int> { }

    public class FirmaRepo : RepositoryBase<Firma, int>
    {
        public Firma GetByUserId(string id) => GetAll().FirstOrDefault(x => x.KullaniciId == id);
    }
    public class FirmaUrunRepo : RepositoryBase<FirmaUrun, int> { }
    public class OdemeTipiRepo : RepositoryBase<OdemeTipi, int> { }
    public class SiparisRepo : RepositoryBase<Siparis, int> {

        public int Insert(SepetViewModel model)
        {
            MyContext db = new MyContext();
            using (db.Database.BeginTransaction())
            {
                try
                {
                    Siparis yeniSiparis = new Siparis()
                    {
                        FirmaId = model.FirmaId,
                        KullaniciId = model.KullaniciId,
                        IstenilenZaman = model.IstenilenTarih,
                        OdemeTipiId = model.OdemeTipiId
                    };
                    db.Siparisler.Add(yeniSiparis);
                    db.SaveChanges();

                    foreach (var item in model.Urunler)
                    {
                        db.SiparisDetaylar.Add(new SiparisDetay()
                        {
                             SiparisId=yeniSiparis.Id,
                             Adet=item.Adet,
                             UrunFiyat=item.Fiyat,
                             UrunId=item.UrunId
                        });
                    }
                    db.SaveChanges();
                    db.Database.CurrentTransaction.Commit();
                }
                catch (Exception ex)
                {
                    db.Database.CurrentTransaction.Rollback();
                }
                return 0;
            }
        }

    }
    public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int> { }
    public class UrunRepo : RepositoryBase<Urun, int> { }
    public class UrunKategoriRepo : RepositoryBase<UrunKategori, int> { }
}
