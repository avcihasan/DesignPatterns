using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DesignPatterns.Decorator.Models;
using DesignPatterns.Decorator.Repositories;
using System.Security.Claims;

namespace DesignPatterns.Decorator.Controllers
{
    public class ProductsController : Controller
    {
        readonly IProductRepository _productRepository;
        
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _productRepository.GetAllAsync(User.Claims.First(x=>x.Type==ClaimTypes.NameIdentifier).Value));
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null || await _productRepository.GetByIdAsync(id) == null)
            {
                return NotFound();
            }
            return View(await _productRepository.GetByIdAsync(id));
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
        public async Task<IActionResult> Create([Bind("Name,Stock,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                product.UserId = User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
                await _productRepository.CreateAsync(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null || await _productRepository.GetByIdAsync(id) == null)
            {
                return NotFound();
            }
            return View(await _productRepository.GetByIdAsync(id));
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,string userId ,[Bind("Name,Stock,Price")] Product product)
        {
           

            if (ModelState.IsValid)
            {
                try
                {
                    product.Id = id;
                    product.UserId = userId;
                    await _productRepository.UpdateAsync(product);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await ProductExists(product.Id))
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
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null || await _productRepository.GetByIdAsync(id) == null)
            {
                return NotFound();
            }
            return View(await _productRepository.GetByIdAsync(id));
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (await _productRepository.GetAllAsync() == null)
            {
                return Problem("Entity set 'AppDbContext.Products'  is null.");
            }
            var product = await _productRepository.GetByIdAsync(id);
            if (product != null)
            {
            await  _productRepository.DeleteAsync(id);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> ProductExists(int id)
        {
            return await _productRepository.GetByIdAsync(id)==null?false:true; 
        }
    }
}
