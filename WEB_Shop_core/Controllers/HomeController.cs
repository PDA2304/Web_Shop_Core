using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WEB_Shop_core.Data;
using WEB_Shop_core.Data.Models;
namespace WEB_Shop_core.Controllers
{
    public class HomeController : Controller
    {

        private readonly ArticlesRepository articlesRepository;

        private AppDBContent db;

        public HomeController(AppDBContent content, ArticlesRepository articlesRepository)
        {
            this.db = content;
            this.articlesRepository = articlesRepository;
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

        public ActionResult User()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> User(RegisteViewModel viewModel)
        {
            if (db.RegisteViewModel.Count() != 0)
            {
                if (!articlesRepository.GetByLogin(viewModel.Login))
                {
                    ModelState.AddModelError(nameof(viewModel.Login), "Такой пользователь уже есть");
                }
                if (!articlesRepository.GetByEmail(viewModel.Email))
                {
                    ModelState.AddModelError(nameof(viewModel.Email), "Такая почта уже использутеся");
                }

            }
            if (ModelState.IsValid)
            {
                Debug.Write("Вы зарегистрировались");
                articlesRepository.SaveArticle(viewModel);
                //db.RegisteViewModel.Add(viewModel);
                //await db.SaveChangesAsync();
                return View("User");
            }
            else
            {
                return View(viewModel);
            }
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

        public async Task<ActionResult> Product_card(int id, string name)
        {
            ViewBag.Title = name;
            var mebel = await db.Mebels.FindAsync(id);
            return View(mebel);
        }

        public ActionResult Personal_Account()
        {
            return View();
        }
    }
}
