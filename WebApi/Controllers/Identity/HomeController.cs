using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Identity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return RedirectToLocal("/dashboard");
           return View();
        }

        public IActionResult Monitor()
        {
            ViewData["Message"] = "Upload Monitor Data.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new CAQM.Identity.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
