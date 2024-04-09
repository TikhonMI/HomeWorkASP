using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcCreditApp.Data;
using MvcCreditApp.Models;
using System.Diagnostics;

namespace MvcCreditApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // шаг2 создание ролей Lab8.3
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;

        // Lab5.2(1)3 создайте экземпляр контекста данных:
        private readonly CreditContext db;

        /* Lab5.2(1)4 изменили  
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */

        /* шаг3 добавляем роли в конструктор Lab8.3
        //Lab5.2(1)4 внедрение зависимости с помощью конструктора контроллера
        public HomeController(ILogger<HomeController> logger, CreditContext context)
        {
            _logger = logger;
            db = context;
        }        */
        public HomeController(ILogger<HomeController> logger, CreditContext context, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            db = context;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        // шаг4 метод создания роли Admin Lab8.3
        public async Task CreateRole()
        {
            string roleName = "Admin";
            if(!await roleManager.RoleExistsAsync(roleName))
            {
                await roleManager.CreateAsync(new IdentityRole { Name = roleName });
            }
        }
        // шаг5 метод добавления юзера в роль Lab8.3
        public async Task AddRole()
        {
            string roleName = "Admin";
            if (!string.IsNullOrEmpty(roleName))
            {
                var usr = await userManager.GetUserAsync(this.User); //получить текущего юзера
                await userManager.AddToRoleAsync(usr,roleName);
            }
        }
        // шаг6 метод вызова метода создания и добавления юзера в роль Admin Lab8.3
        [Authorize]
        public async Task<ViewResult> Privacy()
        {
            await CreateRole();
            await AddRole();
            return View();
        }
        // шаг7 метод просмотра ролей Lab8.3
        [Authorize(Roles = "Admin")]
        public async Task<ViewResult> About()
        {
            ViewBag.Message = "Your application description page.";
            IList<string> roles = new List<string> { "Роль не определена" };
            var user = await userManager.GetUserAsync(this.User);
            if (user != null)
                roles = await userManager.GetRolesAsync(user);
            ViewBag.rol = roles;

            return View();
        }
        // шаг8 добавляем представление About Lab8.3
        // работа с ролями видео 2024-04-02 1:13



        public IActionResult Index()
        {
            /* Lab5.2(3)2 Заменяем код на вызов метода GiveCredits()
            //Lab5.2(1)5 обратитесь к контексту, получите все записи о кредитах, создайте свойство Credits в объекте ViewBag и присвойте ему извлеченный список(объект ViewBag является таким объектом, который с помощью свойства передает данные в представление):
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
            */
            GiveCredits();

            return View();
        }

        //Lab5.2(3)1 Добавьте метод для получения информации о существующих кредитах
        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }
        //Lab7.1(1)1
        public ActionResult BidSearch(string name)
        {
            var allBids = db.Bids.Where(a =>
            a.CreditHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Указанный кредит " + name + " не найден");
                //return HttpNotFound();
            }
            return PartialView(allBids);
        }

        // 8.2.1
        [Authorize]
        // Lab5.2(3)3.a Выполняется при получении запроса GET, возвращает соответствующее представление c получением всех записей о кредитах и заявках:
        [HttpGet]
        public ActionResult CreateBid()
        {

            GiveCredits();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;

            return View();
        }

        // Lab5.2(3)3.b Выполняется при получении запроса POST,принимает переданную ему в запросе POST модель newBid и добавляет ее в базу данных.В конце возвращается строка уведомительного сообщения:
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, " + newBid.Name + ", за выбор нашего банка.Ваша заявка будет рассмотрена в течении 10 дней.";
        }
        /*
        public IActionResult Privacy()
        {
            return View();
        }
        */
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}