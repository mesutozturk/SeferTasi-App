using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Models.Entities
{
    [Table("SiparisDetaylar")]
    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }

        public int Adet { get; set; }
        [Display(Name = "Fiyat")]
        public decimal UrunFiyat { get; set; }

        [ForeignKey("SiparisId")]
        public virtual Siparis Siparis { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }

    }
}
