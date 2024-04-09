/* ������ ������ RazorPages
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//����� MapGet: �������� HTTP-������� GET �� �������� URL-����� / ������� �������, � ����� HTTP ������������ Hello World!.
//���� ����� ������� �� �������� GET ��� ���� �������� URL-����� �� /, ������������� �������� �� ����������� � ������������ ��������� �� ������ HTTP 404.
app.MapGet("/", () => "Hello World!"); 

app.Run();
*/

using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// �������� ������� � ���������.
builder.Services.AddRazorPages(); //��������� � ���������� ������ ��� Razor Pages.
var app = builder.Build();

// ��������� ��������� HTTP-��������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // �������� HSTS �� ��������� � 30 ����. ��������, �� �������� �������� ��� ��� ���������������� ���������, ��. https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages(); //��������� � IEndpointRouteBuilder �������� ����� ��� Razor Pages.
app.Run();