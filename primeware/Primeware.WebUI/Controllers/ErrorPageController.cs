using Microsoft.AspNetCore.Mvc;

namespace Primeware.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index(int code)
        {
            return View();
        }
    }
}
