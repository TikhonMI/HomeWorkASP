using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MvcCreditApp.Data;
using MvcCreditApp.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>() // 1 ��� ��� ���������� ���� Lab8.3
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<CreditContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CreditContext") ?? throw new InvalidOperationException("Connection string 'CreditContext' not found."))); //Lab5.1(3)4 �������� ���� ������ � ������� ���������� ��������� ������������.

var app = builder.Build();

//Lab5.1(3)13 �������� ��������� ���:
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//8
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
