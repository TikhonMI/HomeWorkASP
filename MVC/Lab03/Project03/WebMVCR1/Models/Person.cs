namespace WebMVCR1.Models
{
    // Lab3.2(1)Реализация модели.1 добавили класс Person в папку Models
    public class Person
    {
        // Lab3.2(1)Реализация модели.2 добавили поля, описывающие имя и фамилию персоны, а также переопределите метод ToString()
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => FirstName + " " + LastName;
        // Lab3.2(1)Реализация модели.3 построили приложение
    }
}
