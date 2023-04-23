using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlaygroundNetAPI.Data;
using PlaygroundNetAPI.Models;

namespace PlaygroundNetAPI.Endpoints
{
    [Route("api/[controller]")]
    [ApiController]
    public class RawIngredientsController : ControllerBase
    {
        private readonly PlaygroundNetAPIContext _context;

        public RawIngredientsController(PlaygroundNetAPIContext context)
        {
            _context = context;
        }

        // GET: api/RawIngredients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RawIngredient>>> GetRawIngredient()
        {
            if (_context.RawIngredient == null)
            {
                return NotFound();
            }
            return await _context.RawIngredient.ToListAsync();
        }

        // GET: api/RawIngredients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RawIngredient>> GetRawIngredient(int id)
        {
            if (_context.RawIngredient == null)
            {
                return NotFound();
            }
            var rawIngredient = await _context.RawIngredient.FindAsync(id);

            if (rawIngredient == null)
            {
                return NotFound();
            }

            return rawIngredient;
        }

        // PUT: api/RawIngredients/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRawIngredient(int id, RawIngredient rawIngredient)
        {
            if (id != rawIngredient.ID)
            {
                return BadRequest();
            }

            _context.Entry(rawIngredient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RawIngredientExists(id))
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

        // POST: api/RawIngredients
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RawIngredient>> PostRawIngredient(RawIngredient rawIngredient)
        {
            if (_context.RawIngredient == null)
            {
                return Problem("Entity set 'PlaygroundNetAPIContext.RawIngredient'  is null.");
            }
            _context.RawIngredient.Add(rawIngredient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRawIngredient", new { id = rawIngredient.ID }, rawIngredient);
        }

        // DELETE: api/RawIngredients/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRawIngredient(int id)
        {
            if (_context.RawIngredient == null)
            {
                return NotFound();
            }
            var rawIngredient = await _context.RawIngredient.FindAsync(id);
            if (rawIngredient == null)
            {
                return NotFound();
            }

            _context.RawIngredient.Remove(rawIngredient);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RawIngredientExists(int id)
        {
            return (_context.RawIngredient?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
