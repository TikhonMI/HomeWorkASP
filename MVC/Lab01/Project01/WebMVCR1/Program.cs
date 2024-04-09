var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //Lab1.1.7 ����� AddControllersWithViews() ��������� � ��������� �������� �������, ������� ���������� ��� ������ ������������ MVC.

var app = builder.Build();

/*
 � ASP.NET Core MVC ������������ ������������� ��� ������������� URL-
������� �������� �������� � ����������. �������� ������������ � ���� �������
(���� Program.cs). ��� ��������� ��, ��� ���� URL-������� ������
�������������� � ����������. � ������� ��������� ����� ����������� URL-
������ (��� ������), ������������ � �������.
 */
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
/*
Lab1.1.8-1.11
������� ����� MapControllers() ��� �����������
�������� ����������� (����� ������ app.MapGet() �������).
MapControllers() ����� �������� ������������� ������� MapDefaultControllerRoute().
 */
//app.MapGet("/", () => "Hello World!");

app.Run();
