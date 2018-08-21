using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace passportWizard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Fee1()
        {
            return View();
        }

        public IActionResult Alerts()
        {
            return View();
        }

        public IActionResult ProgressBars()
        {
            return View();
        }

        public IActionResult LostOrStolen1()
        {
            return View();
        }

    }
}
