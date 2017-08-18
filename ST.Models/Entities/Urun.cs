using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Models.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        [Display(Name = "Ürün Adı")]
        public string UrunAdi { get; set; }
        public string UrunFotografYolu { get; set; }
        public int UrunKategoriId { get; set; }

        [ForeignKey("UrunKategoriId")]
        public virtual UrunKategori UrunKategori { get; set; }
        public virtual List<FirmaUrun> FirmaUrunler { get; set; } = new List<FirmaUrun>();
    }
}
