using System;
using System.Linq;
using System.Threading.Channels;
using System.Threading.Tasks;
using EveningSchool.Business.Interfaces;
using EveningSchool.Migrations;
using EveningSchool.Models;
using Microsoft.AspNetCore.Identity;

namespace EveningSchool.Business.Services
{
    public class SeedDatabaseService : ISeedDatabaseService
    {
        private readonly ApplicationContext db;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;

        public SeedDatabaseService(ApplicationContext db, RoleManager<IdentityRole> roleManager,UserManager<User> userManager)
        {
            this.roleManager = roleManager;
            this.db = db;
            this.userManager = userManager;
        }

        public async Task CreateStartAdmin()
        {
            if (db.Users.Any(x => x.UserName == "Admin"))
            {
                Console.WriteLine("Админ уже есть");   
            }
            else
            {
                var user = new User
                {
                    Email = "admin@eveningschool.com", UserName = "Admin",
                    UserImage = "https://img.icons8.com/material-outlined/200/000000/user--v1.png"
                };

                await userManager.CreateAsync(user, "123Snp-");
                await db.SaveChangesAsync();
                await userManager.AddToRoleAsync(user, "Admin");
                Console.WriteLine("Админ создан");
            }
        }

        public async Task CreateStartRole()
        {
            if (db.Roles.Any(x => x.Name == "Admin"))
            {
                Console.WriteLine("Роль админа есть");
            }
            else
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
                Console.WriteLine("Роль админа создана");
            }
            
            if (db.Roles.Any(x => x.Name == "Teacher"))
            {
                Console.WriteLine("Роль учителя есть");
            }
            else
            {
                await roleManager.CreateAsync(new IdentityRole("Teacher"));
                Console.WriteLine("Роль учителя создана");
            }
        }

        public async Task CreateRegisterCode()
        {
            var registerCode = db.RegisterCodes.FirstOrDefault();
            if (registerCode == null)
            {
                await db.RegisterCodes.AddAsync(new RegisterCode {Code = "12345"});
                await db.SaveChangesAsync();
            }
        }
    }
}