using System.ComponentModel;

namespace WebMVCR1.Models
{
    // Lab3.2(1)Реализация модели.1 добавили класс Person в папку Models
    public class Person
    {
        // Lab3.2(1)Реализация модели.2 добавили поля, описывающие имя и фамилию персоны, а также переопределите метод ToString()
        [DisplayName("Имя")] // Lab4.1.3 атрибуты для генерации разметки
        public string FirstName { get; set; } // Lab3.2(1).2
        [DisplayName("Фамилия")] // Lab4.1.3 атрибуты для генерации разметки
        public string LastName { get; set; } // Lab3.2(1).2
        public override string ToString() => FirstName + " " + LastName; // Lab3.2(1).2
        // Lab3.2(1)Реализация модели.3 построили приложение
    }
}
