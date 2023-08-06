using DesignPatterns.Command.Models;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Collections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
builder.Services.AddDbContext<AppDbContext>(options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
});

builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AppDbContext>();
var app = builder.Build();

using var scope = app.Services.CreateScope();
var userManager = scope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
if (!userManager.Users.Any())
{
    userManager.CreateAsync(new AppUser() {Id=Guid.NewGuid().ToString() ,UserName = "user1", Email = "user1@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user2", Email = "user2@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user3", Email = "user3@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user4", Email = "user4@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user5", Email = "user5@outlook.com" }, "Password12*").Wait();


    Enumerable.Range(1, 50).ToList().ForEach(x =>
    {
        context.Products.Add(new() { Name = $"Product {x}", Price = 10 * x, Stock = 100 * x });
    });
    context.SaveChanges();
}
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
