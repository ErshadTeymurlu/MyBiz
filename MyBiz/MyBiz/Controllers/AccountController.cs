using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBiz.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<IdentityUser> _userManager { get;}
        private SignInManager<IdentityUser> _signInManager { get; }
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (!ModelState.IsValid) return View(lvm);
            IdentityUser user = await _userManager.FindByEmailAsync(lvm.Email);
            await _signInManager.SignInAsync(user, false);
            return RedirectToAction("Index","Home",new {area = "Admin"});
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (!ModelState.IsValid)
            {
                return View(rvm);
            }
            IdentityUser user = new IdentityUser()
            {
                Email = rvm.Email,
                UserName = rvm.Email.Split("@")[0]
            };
            IdentityResult result = await _userManager.CreateAsync(user,rvm.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View(rvm);
            }
            return RedirectToAction("Login");
        }
    }
}
