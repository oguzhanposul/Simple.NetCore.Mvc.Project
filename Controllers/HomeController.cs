using System;
using Microsoft.AspNetCore.Mvc;

namespace MiniProjectCourseApp2.Controllers
{
    public class HomeController : Controller
    {
        //localhost:5000/
        //localhost:5000/Home
        //localhost:5000/Home/Index
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            ViewBag.Greeting = saat > 12 ? "İyi günler" : "Günaydın";
            ViewBag.UserName = "Ahmet";

            return View();
        }

        //localhost:5000/Home/About
        public IActionResult About()
        {
            return View();
        }

    }
}