namespace WebMVCR1.Models
{
    // Lab1.3.1 Добавили класс, в которую будет перенесена логика приложения.
    public class ModelClass
    {
        // Lab1.3.2 Перенесли код расчета приветствия из MyController
        public static string ModelHello()
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        }
    }
}
