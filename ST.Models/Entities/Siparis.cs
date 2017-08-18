using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ST.Models.IdentityModels;

namespace ST.Models.Entities
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Sipariş Zamanı")]
        public DateTime SiparisZamani { get; set; } = DateTime.Now;
        [Display(Name = "Onaylanma Zamanı")]
        public DateTime? OnaylanmaZamani { get; set; }
        [Display(Name = "Teslim Zamanı")]
        public DateTime? TeslimZamani { get; set; }
        public byte? Puan { get; set; }
        public int OdemeTipiId { get; set; }
        public string KullaniciId { get; set; }
        public int AdresId { get; set; }
        public int FirmaId { get; set; }

        [ForeignKey("OdemeTipiId")]
        public virtual OdemeTipi OdemeTipi { get; set; }

        [ForeignKey("KullaniciId")]
        public virtual ApplicationUser Kullanici { get; set; }

        [ForeignKey("AdresId")]
        public virtual Adres Adres { get; set; }

        [ForeignKey("FirmaId")]
        public virtual Firma Firma { get; set; }

        public virtual List<SiparisDetay> SiparisDetaylar { get; set; }= new List<SiparisDetay>();
    }
}
