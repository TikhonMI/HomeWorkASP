namespace WebMVCR1.Models
{
    //Lab3.3(1)Добавление модели - репозитория.1 Добавили в папку Models класс PersonRepository
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>(); //Lab3.3(1)Добавление модели - репозитория.2 Добавили поле, описывающие коллекцию – список персон

        //Lab3.3(1)Добавление модели - репозитория.3 два свойства только для чтения – первое должно возвращать количество персон, второе – саму коллекцию:
        public int NumberOfPerson
        {
            get
            {
                return persons.Count(); //возвращает количество персон
            }
        }
        public IEnumerable<Person> GetAllResponses
        {
            get
            {
                return persons; //возвращает саму коллекцию
            }
        }

        //Lab3.3(1)Добавление модели - репозитория.4 метод для возможности добавления персон в коллекцию
        public void AddResponse(Person pers)
        {
            persons.Add(pers);
        }
    }
}
