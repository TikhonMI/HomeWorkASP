using Microsoft.AspNetCore.Mvc;
using System;
using WebMVCR1.Models;

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
    public class MyController : Controller //Lab1.2 Переименовали HomeController в MyController, в Program переименовали Home в My
    {
        /* убрали в Lab1.1.6
        public IActionResult Index() //метод действия Index().
        {
            return View();
        }
        */

        /* убрали в Lab1.2.1
        // Lab1.1.6 Для тестирование контроллера добавили метод который возвращает строку приветствия в зависимости от времени дня:
        public string Index()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        }
        */

        /* убрали в Lab1.3.3
        // Lab1.2.2-2.4 Изменили метод Index()
        // Стандартный get-запрос принимает примерно следующую форму: /метод? параметр1 = значение1 & параметр2 = значение2
        // Для проверки работы метода действия, принимающий параметр измените URL на следующий адрес: localhost:port/My/Index?hel=Иван
        public string Index(string hel) //добавивили передаваемый ему строковый параметр (hel)
        {
            int hour = DateTime.Now.Hour;
            //в теле метода присвоили строковой переменной сообщение с передаваемым параметром(hel)
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel; 
            return Greeting;
        }
        */

        public string Index(string hel)
        {
            string Greeting = ModelClass.ModelHello() + ", " + hel; // Lab1.3.3 Вызываем метод ModelHello из класса ModelClass
            return Greeting;
        }
    }
}
