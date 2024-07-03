using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCore6CrudOperations.Data;
using MVCore6CrudOperations.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCore6CrudOperationsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCore6CrudOperationsContext") ?? throw new InvalidOperationException("Connection string 'MVCore6CrudOperationsContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<MVCore6CrudOperationsContext>(item => item.UseSqlServer(config.GetConnectionString("MVCCore6CrudOperations")));

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
