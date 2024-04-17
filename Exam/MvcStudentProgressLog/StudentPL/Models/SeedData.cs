using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StudentPL.Data;

namespace StudentPL.Models
{
    public class SeedData
    {        
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentPLContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StudentPLContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any()) //Если в базе данных есть ученик, возвращается инициализатор заполнения и учеников не добавляются.
                {
                    return;   // DB has been seeded
                }
                context.Student.AddRange(
                    new Student
                    {
                        Name = "Иванов Иван",
                        RussianLanguage = 5,
                        Literature = 3,
                        ForeignLanguage = 5,
                        Algebra = 5,
                        Geometry = 4,
                        ComputerScience = 5,
                        Story = 5,
                        SocialScience = 5,
                        Economy = 5,
                        Geography = 4,
                        Physics = 5,
                        Astronomy = 5,
                        Chemistry = 4,
                        Biology = 5,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Смирнов Глеб",
                        RussianLanguage = 5,
                        Literature = 5,
                        ForeignLanguage = 5,
                        Algebra = 4,
                        Geometry = 5,
                        ComputerScience = 5,
                        Story = 5,
                        SocialScience = 5,
                        Economy = 4,
                        Geography = 5,
                        Physics = 4,
                        Astronomy = 5,
                        Chemistry = 5,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Кузнецова Виктория",
                        RussianLanguage = 5,
                        Literature = 4,
                        ForeignLanguage = 5,
                        Algebra = 4,
                        Geometry = 5,
                        ComputerScience = 5,
                        Story = 5,
                        SocialScience = 5,
                        Economy = 5,
                        Geography = 5,
                        Physics = 5,
                        Astronomy = 4,
                        Chemistry = 5,
                        Biology = 4,
                        LifeSafetyFundamentals = 4,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Попов Никита",
                        RussianLanguage = 4,
                        Literature = 3,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 4,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Васильев Владислав",
                        RussianLanguage = 4,
                        Literature = 4,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 4,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Петрова Мария",
                        RussianLanguage = 4,
                        Literature = 5,
                        ForeignLanguage = 5,
                        Algebra = 4,
                        Geometry = 5,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 5,
                        Physics = 4,
                        Astronomy = 5,
                        Chemistry = 4,
                        Biology = 5,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Соколов Степан",
                        RussianLanguage = 4,
                        Literature = 3,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 3,
                        Astronomy = 4,
                        Chemistry = 5,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Михайлова Анна",
                        RussianLanguage = 5,
                        Literature = 5,
                        ForeignLanguage = 5,
                        Algebra = 5,
                        Geometry = 5,
                        ComputerScience = 5,
                        Story = 5,
                        SocialScience = 5,
                        Economy = 5,
                        Geography = 5,
                        Physics = 5,
                        Astronomy = 5,
                        Chemistry = 5,
                        Biology = 5,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Ларионов Арсений",
                        RussianLanguage = 5,
                        Literature = 3,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 3,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 3,
                        Economy = 4,
                        Geography = 5,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 3,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Воронов Роман",
                        RussianLanguage = 5,
                        Literature = 4,
                        ForeignLanguage = 5,
                        Algebra = 4,
                        Geometry = 5,
                        ComputerScience = 4,
                        Story = 5,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 5,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 4,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Данилова Ева",
                        RussianLanguage = 5,
                        Literature = 5,
                        ForeignLanguage = 5,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 5,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 5,
                        Physics = 4,
                        Astronomy = 5,
                        Chemistry = 5,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Захаров Андрей",
                        RussianLanguage = 4,
                        Literature = 5,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 3,
                        ComputerScience = 5,
                        Story = 4,
                        SocialScience = 5,
                        Economy = 4,
                        Geography = 4,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 3,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Королёв Лев ",
                        RussianLanguage = 5,
                        Literature = 4,
                        ForeignLanguage = 4,
                        Algebra = 5,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 5,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 5,
                        Physics = 4,
                        Astronomy = 5,
                        Chemistry = 4,
                        Biology = 5,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Григорьева София",
                        RussianLanguage = 5,
                        Literature = 5,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 5,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 5,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 5
                    },
                    new Student
                    {
                        Name = "Носов Григорий",
                        RussianLanguage = 4,
                        Literature = 5,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 5,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 5,
                        Astronomy = 4,
                        Chemistry = 4,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Молчанова Ольга",
                        RussianLanguage = 4,
                        Literature = 3,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 4,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    },
                    new Student
                    {
                        Name = "Иванова Елена",
                        RussianLanguage = 4,
                        Literature = 3,
                        ForeignLanguage = 4,
                        Algebra = 4,
                        Geometry = 4,
                        ComputerScience = 4,
                        Story = 4,
                        SocialScience = 4,
                        Economy = 4,
                        Geography = 4,
                        Physics = 4,
                        Astronomy = 4,
                        Chemistry = 4,
                        Biology = 4,
                        LifeSafetyFundamentals = 5,
                        PhysicalCulture = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
