﻿using CI_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CI_Platform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Forgotpassword()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Resetpassword()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult homegrid()
        {
            return View();
        }
        public IActionResult homelist()
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