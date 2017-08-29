using System.Collections.Generic;

namespace ST.Models.ViewModels
{
    public class FirmaUrunleriViewModel
    {
        public int Id { get; set; }
        public string FirmaAdi { get; set; }
        public decimal MinimumSiparisTutari { get; set; }
        public byte OrtalamaSiparisSuresi { get; set; }
        public List<FirmaUrunKategoriViewModel> Urunler { get; set; } = new List<FirmaUrunKategoriViewModel>();

    }
    public class FirmaUrunKategoriViewModel
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public string KategoriAdi { get; set; }
        public string KategoriAciklama { get; set; }
        public decimal Fiyat { get; set; }
        public string FiyatGorunum { get; set; }
        public int Adet { get; set; } = 1;
        public string UrunResimPath { get; set; }
    }
}
