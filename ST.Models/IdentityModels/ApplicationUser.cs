using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ST.Models.IdentityModels
{
    public class ApplicationUser : IdentityUser
    {
        [Index(IsUnique = true)]
        public override string Email { get; set; }
        [Index(IsUnique = true)]
        public override string UserName { get; set; }

        [StringLength(25)]
        [Required]
        public string Name { get; set; }
        [StringLength(35)]
        [Required]
        public string Surname { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime RegisterDate { get; set; } = DateTime.Now;
    }
}
