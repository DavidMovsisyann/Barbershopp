using BarberShopp.Repository_Interfaces;
using BarberShopp.Service_Interfaces;
using BarberShopp.Services;
using BarberShopp.Repositories;
using Microsoft.EntityFrameworkCore;
using BarberShopp.DataBase;
using Microsoft.AspNetCore.Identity;
using Barbershopp.Data;
using Barbershopp.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();


builder.Services.AddDbContext<DataBaseContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"));
});


builder.Services.AddDefaultIdentity<BarbershoppUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<BarbershoppContext>();
builder.Services.AddDbContext<BarbershoppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("BarbershoppIdentityContextConnection"));
});


builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IBookingHistoryService, BookingHistoryService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<IBarberServicesService, ServiceService>();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pages}/{action=Home}/{id?}");


app.MapRazorPages();

app.Run();
