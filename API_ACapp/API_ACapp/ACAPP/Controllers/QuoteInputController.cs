using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ACapp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.RateLimiting;

namespace ACAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    [EnableRateLimiting("token")]

    public class QuoteInputController : ControllerBase
    {
        private readonly ACAPPContext _context;

        public QuoteInputController(ACAPPContext context)
        {
            _context = context;
        }

        // GET: api/QuoteInput
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Quote_Input>>> GetQuote_Input()
        {
          if (_context.Quote_Input == null)
          {
              return NotFound();
          }
            return await _context.Quote_Input.ToListAsync();
        }

        // GET: api/QuoteInput/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Quote_Input>> GetQuote_Input(int id)
        {
          if (_context.Quote_Input == null)
          {
              return NotFound();
          }
            var quote_Input = await _context.Quote_Input.FindAsync(id);

            if (quote_Input == null)
            {
                return NotFound();
            }

            return quote_Input;
        }

        // PUT: api/QuoteInput/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuote_Input(int id, Quote_Input quote_Input)
        {
            if (id != quote_Input.quote_input_id)
            {
                return BadRequest();
            }

            _context.Entry(quote_Input).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Quote_InputExists(id))
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

        // POST: api/QuoteInput
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Quote_Input>> PostQuote_Input(Quote_Input quote_Input)
        {
          if (_context.Quote_Input == null)
          {
              return Problem("Entity set 'ACAPPContext.Quote_Input'  is null.");
          }
            _context.Quote_Input.Add(quote_Input);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetQuote_Input", new { id = quote_Input.quote_input_id }, quote_Input);
        }

        // DELETE: api/QuoteInput/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteQuote_Input(int id)
        {
            if (_context.Quote_Input == null)
            {
                return NotFound();
            }
            var quote_Input = await _context.Quote_Input.FindAsync(id);
            if (quote_Input == null)
            {
                return NotFound();
            }

            _context.Quote_Input.Remove(quote_Input);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Quote_InputExists(int id)
        {
            return (_context.Quote_Input?.Any(e => e.quote_input_id == id)).GetValueOrDefault();
        }
    }
}
