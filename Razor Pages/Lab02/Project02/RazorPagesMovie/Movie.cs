using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie
{
    public class Movie
    {
        public int Id { get; set; } //Поле ID является обязательным для первичного ключа базы данных
        public string? Title { get; set; } //Знак вопроса после string указывает, что свойство допускает значение NULL.
        // Атрибут [DataType], указывающий тип данных в свойстве ReleaseDate. С этим атрибутом:
        //Пользователю не требуется вводить сведения о времени в поле даты.
        //Отображается только дата, а не время.
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
