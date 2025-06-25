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
    public class TiffinAllowanceTimesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TiffinAllowanceTimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TiffinAllowanceTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiffinAllowanceTime>>> GetTiffinAllowanceTimes()
        {
            return await _context.TiffinAllowanceTimes.ToListAsync();
        }

        // GET: api/TiffinAllowanceTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiffinAllowanceTime>> GetTiffinAllowanceTime(string id)
        {
            var tiffinAllowanceTime = await _context.TiffinAllowanceTimes.FindAsync(id);

            if (tiffinAllowanceTime == null)
            {
                return NotFound();
            }

            return tiffinAllowanceTime;
        }

        // PUT: api/TiffinAllowanceTimes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiffinAllowanceTime(string id, TiffinAllowanceTime tiffinAllowanceTime)
        {
            if (id != tiffinAllowanceTime.TiffinAllowanceID)
            {
                return BadRequest();
            }

            _context.Entry(tiffinAllowanceTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiffinAllowanceTimeExists(id))
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

        // POST: api/TiffinAllowanceTimes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiffinAllowanceTime>> PostTiffinAllowanceTime(TiffinAllowanceTime tiffinAllowanceTime)
        {
            _context.TiffinAllowanceTimes.Add(tiffinAllowanceTime);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TiffinAllowanceTimeExists(tiffinAllowanceTime.TiffinAllowanceID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTiffinAllowanceTime", new { id = tiffinAllowanceTime.TiffinAllowanceID }, tiffinAllowanceTime);
        }

        // DELETE: api/TiffinAllowanceTimes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiffinAllowanceTime(string id)
        {
            var tiffinAllowanceTime = await _context.TiffinAllowanceTimes.FindAsync(id);
            if (tiffinAllowanceTime == null)
            {
                return NotFound();
            }

            _context.TiffinAllowanceTimes.Remove(tiffinAllowanceTime);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiffinAllowanceTimeExists(string id)
        {
            return _context.TiffinAllowanceTimes.Any(e => e.TiffinAllowanceID == id);
        }
    }
}
