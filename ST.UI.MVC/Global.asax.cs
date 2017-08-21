using Microsoft.AspNet.Identity;
using ST.BLL.Account;
using ST.Models.IdentityModels;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ST.UI.MVC.App_Start;

namespace ST.UI.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var roleManager = MembershipTools.NewRoleManager();
            if (!roleManager.RoleExists("Admin"))
            {
                roleManager.Create(new ApplicationRole()
                {
                    Name="Admin",
                    Description = "Site Yöneticisi"
                });
            }
            if (!roleManager.RoleExists("Musteri"))
            {
                roleManager.Create(new ApplicationRole()
                {
                    Name = "Musteri",
                    Description = "Uygulama Müşterisi"
                });
            }
            if (!roleManager.RoleExists("Firma"))
            {
                roleManager.Create(new ApplicationRole()
                {
                    Name = "Firma",
                    Description = "Firma Sahibi Üye"
                });
            }
        }
    }
}
