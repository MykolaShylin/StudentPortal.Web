using Microsoft.AspNetCore.Mvc;
using StudentPortal.Web.Models;
using System.Diagnostics;

namespace StudentPortal.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
