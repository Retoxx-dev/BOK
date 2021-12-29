using BOK.Data;
using BOK.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BOK.Models
{
    public class SeedContext
    {

            public static async Task SeedSuperAdmin(UserManager<ApplicationUser> userManager)
            {
                //Seed Default User
                var defaultUser = new ApplicationUser
                {
                    UserName = "a@admin.com",
                    Email = "a@admin.com",
                    FirstName = "Super",
                    LastName = "Admin",
                    PESEL = 12345678910,
                    Address = "None",
                    City = "None",
                    District = "None",
                    PostalCode = 00000
                };
                if (userManager.Users.All(u => u.Id != defaultUser.Id))
                {
                    var user = await userManager.FindByEmailAsync(defaultUser.Email);
                    if (user == null)
                    {
                        await userManager.CreateAsync(defaultUser, "zaq1@WSX");
                    }
                }
            }
    }
}
