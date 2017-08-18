using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ST.Models.Entities;
using ST.Models.IdentityModels;

namespace ST.DAL
{
    public class MyContext : IdentityDbContext<ApplicationUser>
    {
        public MyContext()
            : base("name=MyCon")
        { }

        public virtual DbSet<Firma> Firmalar { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<UrunKategori> UrunKategoriler { get; set; }
        public virtual DbSet<Adres> Adresler { get; set; }
        public virtual DbSet<FirmaUrun> FirmaUrunler { get; set; }
        public virtual DbSet<OdemeTipi> OdemeTipleri { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FirmaUrun>()
                .Property(x => x.UrunFiyat)
                .HasPrecision(7, 2);
        }
    }
}
