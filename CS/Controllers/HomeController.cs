﻿using AspNetCore31Dashboard.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCore31Dashboard.Controllers {
    public class HomeController : Controller {
        public IActionResult Login() {
            return View();
        }

        public IActionResult Dashboard() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
