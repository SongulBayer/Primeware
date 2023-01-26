using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace Primeware.WebUI.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Admin admin)
        {
            Context c = new Context();
            var values = c.Admins.FirstOrDefault(x => x.MailAdress == admin.MailAdress &&
              x.Password == admin.Password);
            if (values != null)
            {
                var claims=new List<Claim> {
                new Claim(ClaimTypes.Name,admin.MailAdress)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("AdminIndex", "Admin");
            }
            else
            {
                return View(); ;
            }
        }
    }
}
