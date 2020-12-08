using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
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

        [Authorize]
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

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                RegisteViewModel user = await db.RegisteViewModel.FirstOrDefaultAsync(u => u.Login == model.Login && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(model.Login); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


        public ActionResult User()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
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

                return View();
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
