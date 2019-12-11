using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NET_Course.Models;

namespace ASP.NET_Course.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //throw new ArgumentNullException("test");
            return View();
            //return Content("this is my text");
            //return new JsonResult(new { name = "test" });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
