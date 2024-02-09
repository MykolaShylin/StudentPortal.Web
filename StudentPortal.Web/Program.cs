global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using StudentPortal.Web.Models.Students.DTOs;
global using StudentPortal.Web.Models.Students;
global using StudentPortal.Web.Models.Students.ResponceModels;
using StudentPortal.Web.DataContext;
using StudentPortal.Web.Helpers;
using StudentPortal.Web.Services.Students;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IStudentService, StudentService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Logbook}/{id?}");

app.Run();
