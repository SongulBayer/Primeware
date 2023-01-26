
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Primeware.WebUI.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
