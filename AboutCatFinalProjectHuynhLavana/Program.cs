using AboutCatFinalProjectHuynhLavana.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CatContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("CatContext")));


var app = builder.Build();

// Configure the HTTP request pipeline.
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
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Change 'Home' to 'Index'

app.MapControllerRoute(
    name: "customRoute",
    pattern: "Cats/Favorites",
    defaults: new { controller = "Cats", action = "Favorites" });

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"); // Change 'Home' to 'Index'

app.Run();

