using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Primeware.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ProductManager pm = new ProductManager(new EfProductRepository());
        ReferenceManager rm = new ReferenceManager(new EfReferenceRepository());
        AboutManager manager = new AboutManager(new EfAboutRepository());

        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult GetList()
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

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            Product product = new Product();
            product.ProductName = p.ProductName;
            product.ProductImage = "/images/9.jpg";
            product.ProductDetails = p.ProductDetails;
            product.ProductDetails2 = p.ProductDetails2;
            product.ProductType = p.ProductType;

            pm.Add(product);
            return RedirectToAction("AdminHome", "Admin");
        }

        public IActionResult DeleteProduct(int id)
        {
            var val = pm.TgetByid(id);
            pm.Delete(val);
            return RedirectToAction("AdminHome", "Admin");
        }

        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var value = pm.TgetByid(id);

            return View(value);

        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            product.ProductImage = "/images/8.jpg";
            pm.Update(product);
            return RedirectToAction("AdminHome", "Admin");
        }
        public IActionResult GetReferenceList()
        {
            var values = rm.getList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddReference()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReference(Reference p)
        {
            Reference reference = new Reference();
            reference.ReferenceName = p.ReferenceName;
            reference.ReferenceImage = "/images/untes.png";


            rm.Add(reference);
            return RedirectToAction("AdminHome", "Admin");
        }
        public IActionResult DeleteReference(int id)
        {
            var val = rm.TgetByid(id);
            rm.Delete(val);
            return RedirectToAction("AdminHome", "Admin");

        }
        [HttpGet]
        public IActionResult EditReference(int id)
        {
            var value = rm.TgetByid(id);

            return View(value);
        }
        [HttpPost]
        public IActionResult EditReference(Reference reference)
        {
            reference.ReferenceImage = "/images/untes.png";
            rm.Update(reference);
            return RedirectToAction("AdminHome", "Admin");
        }
        public IActionResult GetAbout()
        {
            var values = manager.getList();
            return View(values);
        }


        public IActionResult AdminHome()
        {
            return View();
        }
        public IActionResult reference()
        {
            var values = rm.getList();
            var model = new ReferenceViewModel { ListOfReference = values };
            return View(model);
        }
        public IActionResult product()
        {
            var values = pm.getList();
            var model = new ProductViewModel { ListOfProduct = values };
            return View(model);
        }

    }
}
