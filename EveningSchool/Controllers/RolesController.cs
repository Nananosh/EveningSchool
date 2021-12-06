using System.Threading.Tasks;
using EveningSchool.Migrations;
using EveningSchool.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EveningSchool.Controllers
{
    public class RolesController : Controller
    {
        private readonly ApplicationContext _database;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        
        public RolesController(UserManager<User> userManager, SignInManager<User> signInManager,
            ApplicationContext context, RoleManager<IdentityRole> roleManager)
        {
            _database = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        // GET
        public async Task<IActionResult> CreateRole()
        {
            await _roleManager.CreateAsync(new IdentityRole("Admin"));
            await _roleManager.CreateAsync(new IdentityRole("Teacher"));
            return RedirectToAction("Index","Home");
        }
    }
}