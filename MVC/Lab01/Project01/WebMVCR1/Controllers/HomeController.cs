using Microsoft.AspNetCore.Mvc;

/*
Lab1.1.1-1.5
Контроллер используется для определения и группировки набора действий,
действие реализуется как метод контроллера, обрабатывающий запросы, то есть
метод контроллера можно вызвать из Интернет через некоторый URL для
выполнения действия. Запросы сопоставляются с действиями посредством
маршрутизации.
*/

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        /*
        public IActionResult Index() //метод действия Index().
        {
            return View();
        }
        */


        // Lab1.1.6 Для тестирование контроллера добавили метод который возвращает строку приветствия в зависимости от времени дня:
        public string Index()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        }

    }
}
