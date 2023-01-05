using DersBasariliBasarisizWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DersBasariliBasarisizWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(DersBasariliBasarisiz dersBasariliBasarisiz)
        {
            var not_ = dersBasariliBasarisiz.Not;
            var message = string.Empty;
            if (not_ >= 50)
            {
                message = "Başarılı";
            }
            else {
                message = "Başarısız";

            }
            ViewBag.Message = message;
            return View("dersBasariliBasarisiz");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}