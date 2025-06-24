using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRIS_R62.Models;
using HRIS_R62.Models.Attendance_Required;

namespace HRIS_R62.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftEmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ShiftEmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ShiftEmployees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShiftEmployee>>> GetShiftEmployees()
        {
            return await _context.ShiftEmployees.ToListAsync();
        }

        // GET: api/ShiftEmployees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShiftEmployee>> GetShiftEmployee(string id)
        {
            var shiftEmployee = await _context.ShiftEmployees.FindAsync(id);

            if (shiftEmployee == null)
            {
                return NotFound();
            }

            return shiftEmployee;
        }

        // PUT: api/ShiftEmployees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShiftEmployee(string id, ShiftEmployee shiftEmployee)
        {
            if (id != shiftEmployee.ShiftEmployeeID)
            {
                return BadRequest();
            }

            _context.Entry(shiftEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShiftEmployeeExists(id))
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

        // POST: api/ShiftEmployees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ShiftEmployee>> PostShiftEmployee(ShiftEmployee shiftEmployee)
        {
            _context.ShiftEmployees.Add(shiftEmployee);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ShiftEmployeeExists(shiftEmployee.ShiftEmployeeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetShiftEmployee", new { id = shiftEmployee.ShiftEmployeeID }, shiftEmployee);
        }

        // DELETE: api/ShiftEmployees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShiftEmployee(string id)
        {
            var shiftEmployee = await _context.ShiftEmployees.FindAsync(id);
            if (shiftEmployee == null)
            {
                return NotFound();
            }

            _context.ShiftEmployees.Remove(shiftEmployee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShiftEmployeeExists(string id)
        {
            return _context.ShiftEmployees.Any(e => e.ShiftEmployeeID == id);
        }
    }
}
