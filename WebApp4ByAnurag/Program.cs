using Microsoft.EntityFrameworkCore;
using WebApp4ByAnurag.Models;
using WebApp4ByAnurag.Repositories;



var builder = WebApplication.CreateBuilder(args);
var conStr = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StudentDbContext>(options => options.UseSqlServer(conStr));
builder.Services.AddScoped<IRepository<Student>, StudentRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
