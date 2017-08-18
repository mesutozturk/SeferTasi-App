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
    }
}
