using DesignPatterns.Composite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    string user1Id = Guid.NewGuid().ToString();

    userManager.CreateAsync(new AppUser() {Id= user1Id, UserName = "user1", Email = "user1@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user2", Email = "user2@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user3", Email = "user3@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user4", Email = "user4@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user5", Email = "user5@outlook.com" }, "Password12*").Wait();

    Category c1 = new() { Name = "Category 1", UserId = user1Id, ReferenceId = 0 };
    Category c2 = new() { Name = "Category 2", UserId = user1Id, ReferenceId = 0 };
    Category c3 = new() { Name = "Category 3", UserId = user1Id, ReferenceId = 0 };
    context.Categories.AddRange(c1, c2, c3);
    context.SaveChanges();

    Category c11 = new() { Name = "Category 1.1", UserId = user1Id, ReferenceId = c1.Id };
    Category c22 = new() { Name = "Category 2.1", UserId = user1Id, ReferenceId = c2.Id };
    Category c33 = new() { Name = "Category 3.1", UserId = user1Id, ReferenceId = c3.Id };
    context.Categories.AddRange(c11, c22, c33);
    context.SaveChanges();

    Category c111 = new() { Name = "Category 1.1.1", UserId = user1Id, ReferenceId = c11.Id };
    Category c112 = new() { Name = "Category 1.1.2", UserId = user1Id, ReferenceId = c11.Id };
    context.Categories.AddRange(c111, c112);
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
