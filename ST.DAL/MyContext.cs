using Microsoft.AspNet.Identity.EntityFramework;
using ST.Models.IdentityModels;

namespace ST.DAL
{
    public class MyContext : IdentityDbContext<ApplicationUser>
    {
        public MyContext()
            :base("name=MyCon")
        {}


    }
}
