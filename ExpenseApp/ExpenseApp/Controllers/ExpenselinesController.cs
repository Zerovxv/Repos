using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpenseApp.Modules;

namespace ExpenseApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenselinesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ExpenselinesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Expenselines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expenseline>>> GetExpenseline()
        {
            return await _context.Expenseline.ToListAsync();
        }

        // GET: api/Expenselines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Expenseline>> GetExpenseline(int id)
        {
            var expenseline = await _context.Expenseline.FindAsync(id);

            if (expenseline == null)
            {
                return NotFound();
            }

            return expenseline;
        }

        // PUT: api/Expenselines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseline(int id, Expenseline expenseline)
        {
            if (id != expenseline.Id)
            {
                return BadRequest();
            }

            _context.Entry(expenseline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenselineExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Expenselines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Expenseline>> PostExpenseline(Expenseline expenseline)
        {
            _context.Expenseline.Add(expenseline);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenseline", new { id = expenseline.Id }, expenseline);
        }

        // DELETE: api/Expenselines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseline(int id)
        {
            var expenseline = await _context.Expenseline.FindAsync(id);
            if (expenseline == null)
            {
                return NotFound();
            }

            _context.Expenseline.Remove(expenseline);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExpenselineExists(int id)
        {
            return _context.Expenseline.Any(e => e.Id == id);
        }
    }
}
