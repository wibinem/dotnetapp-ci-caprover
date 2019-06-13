using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspnetapp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Halaman Deskripsi About.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Halaman Kontak Anda.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
