using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WEB_Shop_core.Data;
using WEB_Shop_core.Data.Models;
namespace WEB_Shop_core.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

     
        private AppDBContent db;

        public HomeController(AppDBContent content)
        {
            db = content;
        }

        public IActionResult Index()
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
        public async Task<ActionResult> Bedroom()
        {
            IQueryable<Mebel> mebels = db.Mebels.Include(x => x.Category);
            ViewBag.Title = "Спальни";
            return View(await mebels.AsNoTracking().ToListAsync());
        }
        public async Task<ActionResult> Children_Bedroom()
        {
            IQueryable<Mebel> mebels = db.Mebels.Include(x => x.Category);
            ViewBag.Title = "Детская мебель";
            return View(await mebels.AsNoTracking().ToListAsync());
        }
        public async Task<ActionResult> Kitchen()
        {
            IQueryable<Mebel> mebels = db.Mebels.Include(x => x.Category);
            ViewBag.Title = "Кухни";
            return View(await mebels.AsNoTracking().ToListAsync());
        }
        public async Task<ActionResult> Living_Room()
        {
            IQueryable<Mebel> mebels = db.Mebels.Include(x => x.Category);
            ViewBag.Title = "Гостинные";
            return View(await mebels.AsNoTracking().ToListAsync());
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
