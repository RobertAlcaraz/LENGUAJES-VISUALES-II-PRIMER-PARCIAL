using Microsoft.AspNetCore.Mvc;
using EXAMEN_PARCIAL.Properties.Database;
using EXAMEN_PARCIAL.Properties.Models;

namespace EXAMEN_PARCIAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public ProductsController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Products.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            var existing = _context.Products.Find(id);
            if (existing == null) return NotFound();

            existing.Name = product.Name;
            existing.Price = product.Price;
            // Agrega aquí más propiedades si tu modelo las tiene

            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
