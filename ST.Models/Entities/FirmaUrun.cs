using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Models.Entities
{
    [Table("FirmaUrunler")]
    public class FirmaUrun
    {
        [Key]
        [Column(Order = 1)]
        public int FirmaId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunId { get; set; }

        [Display(Name = "Fiyat")]
        public decimal UrunFiyat { get; set; }
        [Display(Name = "Satışta mı?")]
        public bool SatistaMi { get; set; } = false;

        [ForeignKey("FirmaId")]
        public virtual Firma Firma { get; set; }
        [ForeignKey("UrunId")]
        public virtual Urun Urun { get; set; }
    }
}
