using System.ComponentModel.DataAnnotations;

namespace StudentPL.Models
{
    public class Student
    {
        // ID студента
        public int Id { get; set; } //Id, требуется базе данных в качестве первичного ключа
        // Имя студента
        [Display(Name = "Имя учащегося")]
        public string? Name { get; set; } //? после string указывает, что свойство допускает значение NULL
        // Оценка за Русский язык
        [Display(Name = "Рус.язык")]
        public int RussianLanguage { get; set; }
        // Оценка за Литература
        [Display(Name = "Литература")]
        public int Literature { get; set; }
        // Оценка за Иностранный язык
        [Display(Name = "Ин.язык")]
        public int ForeignLanguage { get; set; }
        // Оценка за Алгебра и начала анализа
        [Display(Name = "Алгебра")]
        public int Algebra { get; set; }
        // Оценка за Геометрия
        [Display(Name = "Геометрия")]
        public int Geometry { get; set; }
        // Оценка за Информатика
        [Display(Name = "Информатика")]
        public int ComputerScience { get; set; }
        // Оценка за История
        [Display(Name = "История")]
        public int Story { get; set; }
        // Оценка за Обществознание
        [Display(Name = "Обществознание")]
        public int SocialScience { get; set; }
        // Оценка за Экономика
        [Display(Name = "Экономика")]
        public int Economy { get; set; }
        // Оценка за География
        [Display(Name = "География")]
        public int Geography { get; set; }
        // Оценка за Физика
        [Display(Name = "Физика")]
        public int Physics { get; set; }
        // Оценка за Астрономия
        [Display(Name = "Астрономия")]
        public int Astronomy { get; set; }
        // Оценка за Химия
        [Display(Name = "Химия")]
        public int Chemistry { get; set; }
        // Оценка за Биология
        [Display(Name = "Биология")]
        public int Biology { get; set; }
        // Оценка за ОБЖ
        [Display(Name = "ОБЖ")]
        public int LifeSafetyFundamentals { get; set; }
        // Оценка за Физическая культура
        [Display(Name = "Физ.культура")]
        public int PhysicalCulture { get; set; }
    }
}
