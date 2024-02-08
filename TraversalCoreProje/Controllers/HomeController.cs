﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index sayfası Çağırıldı");
            _logger.LogError("Error Log Çağırıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy sayfası Çağırıldı");
            return View();
        }
        public IActionResult Test()
        {
            DateTime d=Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d+"Test sayfası Çağırıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
