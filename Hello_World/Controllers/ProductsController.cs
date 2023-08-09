using Microsoft.AspNetCore.Mvc;
using MirpurKhasSite.Models;


namespace Hello_World.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration _config;

        public ProductsController(IConfiguration config)
        {
            _config = config;
        }



        public ViewResult ContactUs()
        {
            ViewBag.Title = "Contact";
            return View();
        }

        [HttpPost]
        public ViewResult Save(MirpurKhasSite.Models.ContactUs product)
        {
            if (!ModelState.IsValid)
            {
                return View("AddNewContact");
            }
            // This -> Save(Product product) called automatic model binding.
            ViewBag.Title = "Contact Saved";
            return View(product);

            //return RedirectToAction("Products");
        }
    }
}

