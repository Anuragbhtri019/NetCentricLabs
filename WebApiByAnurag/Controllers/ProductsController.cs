using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiByAnurag.Data;
using WebApiByAnurag.Models;

namespace WebApiByAnurag.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AppDbContext _db;
        public ProductsController(AppDbContext db) => _db = db;

        // GET api/products
        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _db.Products.AsNoTracking().ToListAsync());

        // GET api/products/1
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _db.Products.FindAsync(id);
            return product == null ? NotFound() : Ok(product);
        }

        // POST api/products
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        // PUT api/products/1
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, Product product)
        {
            var existing = await _db.Products.FindAsync(id);
            if (existing == null) return NotFound();

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Description = product.Description;

            await _db.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/products/1
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
