using DesignPatterns.Decorator.Models;
using DesignPatterns.Decorator.Repositories;
using DesignPatterns.Decorator.Repositories.Decorators;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMemoryCache();
builder.Services.AddHttpContextAccessor();

//1.yol
//builder.Services.AddScoped<IProductRepository>(sp =>
//{
//    var memoryCache = sp.GetRequiredService<IMemoryCache>();
//    var context = sp.GetRequiredService<AppDbContext>();
//    var logger = sp.GetRequiredService<ILogger<ProductRepositoryLoggingDecorator>>();
//    ProductRepository prodcutRepository =new(context);
//    ProductRepositoryCacheDecorator cacheDecorator = new(prodcutRepository, memoryCache);
//    ProductRepositoryLoggingDecorator loggingDecorator = new(cacheDecorator, logger);
//    return cacheDecorator;
//});


//2.yol
//builder.Services.AddScoped<IProductRepository, ProductRepository>()
//    .Decorate<IProductRepository, ProductRepositoryCacheDecorator>()
//    .Decorate<IProductRepository, ProductRepositoryLoggingDecorator>();


//3.yol runtime
builder.Services.AddScoped<IProductRepository>(sp =>
{
    var memoryCache = sp.GetRequiredService<IMemoryCache>();
    var context = sp.GetRequiredService<AppDbContext>();
    var logger = sp.GetRequiredService<ILogger<ProductRepositoryLoggingDecorator>>();
    var httpContext = sp.GetRequiredService<IHttpContextAccessor>();

    ProductRepository prodcutRepository = new(context);

    if (httpContext.HttpContext.User.Identity.Name=="user1")
    {
        ProductRepositoryCacheDecorator cacheDecorator = new(prodcutRepository, memoryCache);
        return cacheDecorator;
    }
    ProductRepositoryLoggingDecorator loggingDecorator = new(prodcutRepository, logger);
    return loggingDecorator;
});


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
if (!userManager.Users.Any())
{
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user1", Email = "user1@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user2", Email = "user2@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user3", Email = "user3@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user4", Email = "user4@outlook.com" }, "Password12*").Wait();
    userManager.CreateAsync(new AppUser() { Id = Guid.NewGuid().ToString(), UserName = "user5", Email = "user5@outlook.com" }, "Password12*").Wait();
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
