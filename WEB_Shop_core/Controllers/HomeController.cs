using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public IActionResult RemoveFromCart()

        {

            int number = Convert.ToInt32(Request.Query["Number"]); // Получаем номер позиции в корзине

            Cart cart = new Cart();

            if (HttpContext.Session.Keys.Contains("Cart")) // Проверяем есть ли сохранённая корзина у пользователя

                cart = JsonSerializer.Deserialize<Cart>(HttpContext.Session.GetString("Cart")); // десериализируем корзину из сессии

            cart.CartLines.RemoveAt(number); // Удаляем товар из корзины но индексу

            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize<Cart>(cart)); // Сохраняем новую корзину в сессию

            return Redirect("~/Home/Cart"); //Возвращение пользователя на страницу с корзиной

        }
        public IActionResult AddToCart()
        {

            int ID = Convert.ToInt32(Request.Query["id"]); // Получаем ID из строки

            Cart cart = new Cart();

            if (HttpContext.Session.Keys.Contains("Cart"))//Проверяем есть ли сохранённая корзина у пользователя

                cart = JsonSerializer.Deserialize<Cart>(HttpContext.Session.GetString("Cart")); //десериализируем корзину из сессии

            cart.CartLines.Add(db.Mebels.Find(ID)); //Добавляем в корзину элемент Product по первичному ключу

            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize<Cart>(cart)); // Сохраняем новую корзину в сессию

            return Redirect("~/Home/Index"); //Возвращение пользователя на первоначальную страницу

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
        [HttpGet]
        public ActionResult Cart()
        {
            Cart cart = new Cart();
            if (HttpContext.Session.Keys.Contains("Cart"))//Проверяем есть ли сохранённая корзина у пользователя

                cart = JsonSerializer.Deserialize<Cart>(HttpContext.Session.GetString("Cart"));
            return View(cart);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SuccZakk(SuccZakk zakk)
        {
            if (zakk.Mail != "" && zakk.Telefon != "" && zakk.Name != "" && zakk.Address != "")
            {
                MailAddress from = new MailAddress("Pahomovdaniil02@yandex.ru", "Итальянская мебель");

                MailAddress to = new MailAddress(zakk.Mail);

                MailMessage m = new MailMessage(from, to);

                m.Subject = "Оформление заказа";

                m.Body = "<h2>Спасибо за покупку мебели</h2>";

                m.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient("smtp.yandex.com", 587);
                smtp.Credentials = new NetworkCredential("Pahomovdaniil02@yandex.ru", "lecnoe2002");
                smtp.EnableSsl = true;
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                smtp.Send(m);
                return View("Index", zakk);
            }

            return View("Cart");
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
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, HttpContext.User.Identity.Name)
            };
            claims.Clear();
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки

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
