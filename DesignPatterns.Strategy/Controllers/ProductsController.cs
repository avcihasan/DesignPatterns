using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DesignPatterns.Strategy.Models;
using DesignPatterns.Strategy.Repositories;
using Microsoft.AspNetCore.Identity;

namespace DesignPatterns.Strategy.Controllers
{
    public class ProductsController : Controller
    {
        readonly IProductRepository _productRepository;
        readonly UserManager<AppUser> _userManager;
   
        public ProductsController(IProductRepository productRepository, UserManager<AppUser> userManager)
        {
            _productRepository = productRepository;
            _userManager = userManager;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            return View(await _productRepository.GetProductsByUserIdAsync(user.Id));
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || await _productRepository.GetProductAsync(id) == null)
            {
                return NotFound();
            }
            var product = await _productRepository.GetProductAsync(id);
         
            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Price,Stock,UserId,CreatedDate")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.CreatedDate = DateTime.Now;
                product.UserId = (await _userManager.FindByNameAsync(User.Identity.Name)).Id;
                await _productRepository.CreateProductAsync(product);

                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || await _productRepository.GetProductAsync(id) == null)
            {
                return NotFound();
            }

            var product = await _productRepository.GetProductAsync(id);
           
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Price,Stock,UserId,CreatedDate")] Product product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _productRepository.UpdateProductAsync(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await ProductExists(product.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || await _productRepository.GetProductAsync(id) == null)
            {
                return NotFound();
            }

            var product = await  _productRepository.GetProductAsync(id);
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (await _productRepository.GetProductAsync(id) == null)
                return Problem("Entity set 'AppDbContext.Prodcuts'  is null.");
            var product = await _productRepository.GetProductAsync(id);
            if (product != null)
             await   _productRepository.DeleteProductAsync(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProductExists(string id)
        {
            return await _productRepository.GetProductAsync(id)==null?false:true;
        }
    }
}
