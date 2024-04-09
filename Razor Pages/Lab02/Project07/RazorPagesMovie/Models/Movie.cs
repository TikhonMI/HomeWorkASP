using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } //Поле ID является обязательным для первичного ключа базы данных
        public string? Title { get; set; } = string.Empty; //Знак вопроса после string указывает, что свойство допускает значение NULL.

        [Display(Name = "Release Date")] //указывает на отображаемое имя поля, Release Date вместо ReleaseDate
        // Атрибут [DataType], указывающий тип данных в свойстве ReleaseDate. С этим атрибутом:
        //Пользователю не требуется вводить сведения о времени в поле даты.
        //Отображается только дата, а не время.
        [DataType(DataType.Date)] 
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2)")] //позволяет Entity Framework Core корректно сопоставить Price с валютой в базе данных
        public decimal Price { get; set; }
        public string Rating { get; set; } = string.Empty;
    }
}
