using PizzaApplication.Models;
using PizzaApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//add dependency injection (provider)
builder.Services.AddScoped<IRepo<int, Pizza>, PizzaRepo>();
//add connection string, pls add the conn string in json as well
builder.Services.AddDbContext<PizzaShopContext>(options =>
{
    options.UseSql
}
);

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
    pattern: "{controller=Pizza}/{action=Index}/{id?}");

app.Run();
