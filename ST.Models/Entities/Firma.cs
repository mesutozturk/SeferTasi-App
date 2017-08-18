using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ST.Models.IdentityModels;

namespace ST.Models.Entities
{
    [Table("Firmalar")]
    public class Firma
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Firma Adı")]
        public string FirmaAdi { get; set; }
        [StringLength(200)]
        public string Adres { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(11)]
        public string Telefon { get; set; }
        [DataType(DataType.Url)]
        [StringLength(75)]
        public string WebUrl { get; set; }
        [Display(Name = "Ortalama Teslim Süresi")]
        public byte OrtalamaTeslimSuresi { get; set; } = 15;
        [Display(Name = "Aktif Mi?")]
        public bool AktifMi { get; set; } = false;
        [Column(TypeName = "smalldatetime")]
        [Display(Name = "Eklenme Tarihi")]
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
        public string KullaniciId { get; set; }

        //Navigation Prop.
        [ForeignKey("KullaniciId")]
        public virtual ApplicationUser Kullanicisi { get; set; }

    }
}
