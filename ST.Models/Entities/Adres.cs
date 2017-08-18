using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ST.Models.IdentityModels;

namespace ST.Models.Entities
{
    [Table("Adresler")]
    public class Adres
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Ad")]
        public string AdresAdi { get; set; }
        [Display(Name = "Açık Adres")]
        public string AcikAdres { get; set; }
        [Display(Name = "Eklenme Zamanı")]
        public DateTime EklenmeZamani { get; set; } = DateTime.Now;
        public string KullaniciId { get; set; }

        [ForeignKey("KullaniciId")]
        public virtual ApplicationUser Kullanici { get; set; }
    }
}
