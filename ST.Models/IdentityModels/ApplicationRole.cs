using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ST.Models.IdentityModels
{
   public class ApplicationRole:IdentityRole
    {
        [StringLength(200)]
        public string Description { get; set; }
    }
}