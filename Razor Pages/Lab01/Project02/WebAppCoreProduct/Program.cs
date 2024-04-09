/* Пример пустой RazorPages
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//метод MapGet: отправка HTTP-запроса GET на корневой URL-адрес / делегат запроса, в ответ HTTP записывается Hello World!.
//Если метод запроса не является GET или если корневой URL-адрес не /, сопоставление маршрута не выполняется и возвращается сообщение об ошибке HTTP 404.
app.MapGet("/", () => "Hello World!"); 

app.Run();
*/

using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// Добавьте сервисы в контейнер.
builder.Services.AddRazorPages(); //добавляет в приложение службы для Razor Pages.
var app = builder.Build();

// Настройка конвейера HTTP-запросов
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Значение HSTS по умолчанию — 30 дней. Возможно, вы захотите изменить это для производственных сценариев, см. https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages(); //добавляет в IEndpointRouteBuilder конечные точки для Razor Pages.
app.Run();