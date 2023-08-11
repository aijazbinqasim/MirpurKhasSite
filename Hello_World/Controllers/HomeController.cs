using Microsoft.AspNetCore.Mvc;


namespace MirpurKhasSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public ViewResult Index()
        {

           return View();
        }

       
        public IActionResult About()
        {
            return View();
        }

        public ViewResult Gallery()
        {
            ViewBag.Title = "Gallery";
            return View();
        }

        
    }
}
