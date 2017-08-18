using System;
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

        [ForeignKey("OdemeTipiId")]
        public virtual OdemeTipi OdemeTipi { get; set; }

        [ForeignKey("KullaniciId")]
        public virtual ApplicationUser Kullanici { get; set; }
    }
}
