using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _sıgnInManeger;

        public LoginController(SignInManager<AppUser> sıgnInManeger)
        {
            _sıgnInManeger = sıgnInManeger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]

        public async Task<IActionResult> Index(UserLoginViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _sıgnInManeger.PasswordSignInAsync(p.UserName, p.Password, false, true);
               
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullanıcı adı veya şifre");
                }
            }
            return View();
        }

        public async Task<ActionResult> LogOut()
        {
            await _sıgnInManeger.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}
