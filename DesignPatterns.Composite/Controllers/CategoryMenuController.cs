using DesignPatterns.Composite.Composite;
using DesignPatterns.Composite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace DesignPatterns.Composite.Controllers
{
    [Authorize]
    public class CategoryMenuController : Controller
    {
        readonly AppDbContext _appDbContext;

        public CategoryMenuController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {

            var userId = User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
            var categories = _appDbContext.Categories.Include(x => x.Products).Where(x => x.UserId == userId).OrderBy(x => x.Id).ToList();
            var menu = GetMenu(categories, new() { Id = 0 }, new(0, "TopCompoiste"));
            ViewBag.menu = menu;
            ViewBag.selectList = menu.Components.SelectMany(x => ((BookComposite)x).GetSelectListItems(""));
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(int categoryId, string bookName)
        {
            await _appDbContext.Products.AddAsync(new Product { CategoryId = categoryId, Name = bookName });
            await _appDbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        private BookComposite GetMenu(List<Category> categories, Category topCategory, BookComposite topBookCompoiste, BookComposite last = null)
        {
            categories.Where(x => x.ReferenceId == topCategory.Id).ToList().ForEach(category => 
            {
                BookComposite bookComposite = new(category.Id, category.Name);

                category.Products.ForEach(book =>
                {
                    bookComposite.AddComponent(new BookComponent(book.Id, book.Name));
                });
                if (last is not null)
                    last.AddComponent(bookComposite);
                else
                    topBookCompoiste.AddComponent(bookComposite);

                GetMenu(categories,category,bookComposite,bookComposite);

            });
            return topBookCompoiste;
        }
    }
}
