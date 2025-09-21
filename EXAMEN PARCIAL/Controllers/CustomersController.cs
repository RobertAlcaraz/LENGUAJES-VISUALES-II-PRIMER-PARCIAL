using EXAMEN_PARCIAL.Properties.Database;
using EXAMEN_PARCIAL.Properties.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EXAMEN_PARCIAL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public CustomersController(AplicationDbContext context)
        {
            _context = context;
        }   
        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> Get()
        {
            var result = await _context.Customers.ToListAsync();
            if (result == null || result.Count == 0)
                return NotFound("No customers found.");
            return Ok(result);
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
                return NotFound();
            return Ok(customer);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
