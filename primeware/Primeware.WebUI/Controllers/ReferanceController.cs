using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Primeware.WebUI.Controllers
{
    [AllowAnonymous]
    public class ReferanceController : Controller
    {
        ReferenceManager rm = new ReferenceManager(new EfReferenceRepository());
        public IActionResult Index()
        {
            var values = rm.getList();
            return View(values);
        }
    }
}
