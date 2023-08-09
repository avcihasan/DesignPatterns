using DesignPatterns.Adapter.Models;
using DesignPatterns.Adapter.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPatterns.Adapter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly IImageService _imageService;
        public HomeController(ILogger<HomeController> logger, IImageService imageService)
        {
            _logger = logger;
            _imageService = imageService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddWatermark()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWatermark(IFormFile image)
        {
            if (image is { Length: >= 0 })
            {
                var imageMemoryStream = new MemoryStream();

                await image.CopyToAsync(imageMemoryStream);

                _imageService.AddWatermark("Asp.Net Core MVC", image.FileName, imageMemoryStream);
            }
            return View();
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