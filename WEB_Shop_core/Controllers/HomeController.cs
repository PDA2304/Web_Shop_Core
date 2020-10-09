using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WEB_Shop_core.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Kontakt()
        {
            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult User()
        {
            return View();
        }
        public ActionResult Bedroom()
        {
            return View();
        }
        public ActionResult Children_Bedroom()
        {
            return View();
        }
        public ActionResult Kitchen()
        {
            return View();
        }
        public ActionResult Living_Room()
        {
            return View();
        }

        public ActionResult Product_card()
        {
            return View();
        }

        public ActionResult Personal_Account()
        {
            return View();
        }


    
    }
}
