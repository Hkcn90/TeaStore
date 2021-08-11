using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Data
{
    public class Seed
    {
        public static async Task SeedUsers(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (await userManager.Users.AnyAsync()) return;

            var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
            if (users == null) return;

            var roles = new List<AppRole>{
                new AppRole{Name = "Admin"},
                new AppRole{Name = "Director"},
                new AppRole{Name = "Manager"},
                new AppRole{Name = "Excecutive"},
            };

            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }

            foreach (var user in users)
            {
                user.UserName = user.UserName.ToLower();
                await userManager.CreateAsync(user, "Dev1#123");
                await userManager.AddToRoleAsync(user, "Director");
            }

            var admin = new AppUser
            {
                UserName = "admin"
            };

            await userManager.CreateAsync(admin, "Dev1#123");
            await userManager.AddToRolesAsync(admin, new[] { "Admin", "Director", "Manager", "Excecutive" });

        }
    }
}
