using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Models.Entities
{
    [Table("UrunKategoriler")]
    public class UrunKategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Index(IsUnique = true)]
        [Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }
        [StringLength(200)]
        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }

        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();
    }
}
