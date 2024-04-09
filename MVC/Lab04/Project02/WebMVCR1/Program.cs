var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Lab1.1.7 Метод AddControllersWithViews() добавляет в коллекцию сервисов сервисы, которые необходимы для работы контроллеров MVC.

var app = builder.Build();

//Lab4.2(4)Использование CSS.4 прописать статику в Program.cs app.UseStaticFiles()
app.UseStaticFiles(); //говорит приложению, что не только код в приложении, но и статические файлы в wwwroot находятся.

/*
 В ASP.NET Core MVC используется маршрутизация для сопоставления URL-
адресов входящих запросов с действиями. Маршруты определяются в коде запуска
(файл Program.cs). Они описывают то, как пути URL-адресов должны
сопоставляться с действиями. С помощью маршрутов также формируются URL-
адреса (для ссылок), отправляемые в ответах.
 */
app.MapControllerRoute(name: "default", pattern: "{controller=My}/{action=Index}/{id?}"); //Lab1.2 Переименовали Home в My
                                                                                          //--Lab3.2(3)Настройка контроллера.3 Переименовали My в Home
/*
Lab1.1.8-1.11
Вызвали метод MapControllers() для регистрации
маршрута контроллера (вызов метода app.MapGet() удалили).
MapControllers() можно заменить универсальным методом MapDefaultControllerRoute().
 */
//app.MapGet("/", () => "Hello World!");

app.Run();
