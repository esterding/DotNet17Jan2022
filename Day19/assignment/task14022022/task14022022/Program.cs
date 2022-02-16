using Microsoft.EntityFrameworkCore;
using task14022022.Models;
using task14022022.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string constr = builder.Configuration.GetConnectionString("conn");
builder.Services.AddScoped<IRepo2<int, Product>, ProductRepo>();
builder.Services.AddDbContext<task14022022Context>(opts =>
{
    opts.UseSqlServer(constr);
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
