using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ACapp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.RateLimiting;

namespace ACAPP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    [EnableRateLimiting("token")]

    public class UserInputsController : ControllerBase
    {
        private readonly ACAPPContext _context;

        public UserInputsController(ACAPPContext context)
        {
            _context = context;
        }

        // GET: api/UserInputs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User_Input>>> GetUserInput()
        {
          if (_context.User_Input == null)
          {
              return NotFound();
          }
            return await _context.User_Input.ToListAsync();
        }

        // GET: api/UserInputs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User_Input>> GetUserInput(int id)
        {
          if (_context.User_Input == null)
          {
              return NotFound();
          }
            var userInput = await _context.User_Input.FindAsync(id);

            if (userInput == null)
            {
                return NotFound();
            }

            return userInput;
        }

        // PUT: api/UserInputs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserInput(int id, User_Input userInput)
        {
            if (id != userInput.input_id)
            {
                return BadRequest();
            }

            _context.Entry(userInput).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserInputExists(id))
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

        // POST: api/UserInputs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<User_Input>> PostUserInput(User_Input userInput)
        {
          if (_context.User_Input == null)
          {
              return Problem("Entity set 'ACAPPContext.UserInput'  is null.");
          }

          
            
            _context.User_Input.FromSqlRaw($"UPDATE dbo.user_input SET cost = (SELECT num_windows * ((SELECT device_price FROM device WHERE device_id = 1)+(SELECT installation_cost FROM device WHERE device_id = 1)) WHERE input_id = {userInput.input_id});");

            _context.User_Input.Add(userInput);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetUserInput", new { id = userInput.input_id }, userInput);
        }

        // DELETE: api/UserInputs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserInput(int id)
        {
            if (_context.User_Input == null)
            {
                return NotFound();
            }
            var userInput = await _context.User_Input.FindAsync(id);
            if (userInput == null)
            {
                return NotFound();
            }

            _context.User_Input.Remove(userInput);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserInputExists(int id)
        {
            return (_context.User_Input?.Any(e => e.input_id == id)).GetValueOrDefault();
        }
    }
}
