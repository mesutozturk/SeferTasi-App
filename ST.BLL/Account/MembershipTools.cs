using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ST.DAL;
using ST.Models.IdentityModels;

namespace ST.BLL.Account
{
    public static class MembershipTools
    {
        public static UserStore<ApplicationUser> NewUserStore() 
            => new UserStore<ApplicationUser>(new MyContext());

        public static UserManager<ApplicationUser> NewUserManager() 
            => new UserManager<ApplicationUser>(NewUserStore());

        public static RoleStore<ApplicationRole> NewRoleStore() 
            => new RoleStore<ApplicationRole>(new MyContext());

        public static RoleManager<ApplicationRole> NewRoleManager() 
            => new RoleManager<ApplicationRole>(NewRoleStore());
    }
}
