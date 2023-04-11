using LanchesSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanchesSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["Nome"] = "Josué Diogo Pedro";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}