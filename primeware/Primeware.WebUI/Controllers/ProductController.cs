using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Primeware.WebUI.Controllers
{
    [AllowAnonymous]
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            var values = pm.getList();
            return View(values);
        }
        public IActionResult ProductDetails(int id)
        {
            ViewBag.i = id;
            var values = pm.GetProductById(id);
            return View(values);
        }
      
        
    }
}
