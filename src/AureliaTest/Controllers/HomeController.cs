using Microsoft.AspNetCore.Mvc;

namespace AureliaTest.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Host()
        {
            return View();
        }

        [Route("index")]
        public IActionResult Index()
        {
            return PartialView();
        }

        [Route("app")]
        public IActionResult App()
        {
            return PartialView();
        }

        [Route("nav-bar")]
        public IActionResult NavBar()
        {
            return PartialView();
        }

        [Route("flickr")]
        public IActionResult Flickr()
        {
            return PartialView();
        }

        [Route("test-page")]
        public IActionResult TestPage()
        {
            return PartialView();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}