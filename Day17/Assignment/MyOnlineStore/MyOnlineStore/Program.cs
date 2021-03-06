using Microsoft.EntityFrameworkCore;
using MyOnlineStore.Models;
using MyOnlineStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRepo<int, Customer>, CustomerEFRepo>();
string conn = builder.Configuration.GetConnectionString("conn");
builder.Services.AddDbContext<CustomerContext>(options =>
{
    options.UseSqlServer(conn);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
