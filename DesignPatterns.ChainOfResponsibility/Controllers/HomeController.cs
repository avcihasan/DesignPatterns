using DesignPatterns.ChainOfResponsibility.ChainOfResponsibility;
using DesignPatterns.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DesignPatterns.ChainOfResponsibility.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly AppDbContext _appDbContext;
        readonly ProcessHandler _processHandler;
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, ProcessHandler processHandler )
        {
            _logger = logger;
            _appDbContext = appDbContext;
            _processHandler = processHandler;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DownloadExcel(string model)
        {
            if (model == "product")
            {
                var products = await _appDbContext.Products.ToListAsync();
                var handlerr = _processHandler.Handler(products, typeof(Product)) as byte[];
                return File(handlerr, "application/zip", "Products.zip");
            }
            var categories = await _appDbContext.Categories.ToListAsync();
            var handlerrr = _processHandler.Handler(categories,typeof(Category)) as byte[];
            return File(handlerrr, "application/zip", "Categories.zip");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}