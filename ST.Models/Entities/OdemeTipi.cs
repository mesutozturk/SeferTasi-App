using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ST.Models.Entities
{
    [Table("OdemeTipleri")]
    public class OdemeTipi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ödeme Tipi")]
        public string OdemeTipiAdi { get; set; }
    }
}
