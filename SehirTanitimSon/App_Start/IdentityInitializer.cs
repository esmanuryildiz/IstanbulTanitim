using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SehirTanitimSon.Models;

namespace SehirTanitimSon.App_Start
{
    public class IdentityInitializer
    {
        public static void SeedAdminAndRoles()
        {
            var context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            // ROLLERİ OLUŞTUR
            if (!roleManager.RoleExists("Admin"))
                roleManager.Create(new IdentityRole("Admin"));

            if (!roleManager.RoleExists("Uye"))
                roleManager.Create(new IdentityRole("Uye"));

            // ADMIN KULLANICI VAR MI?
            var adminUser = userManager.FindByEmail("admin@admin.com");
            if (adminUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com"
                };

                var result = userManager.Create(user, "Admin123!");

                if (result.Succeeded)
                    userManager.AddToRole(user.Id, "Admin");
            }
        }
    }
}
