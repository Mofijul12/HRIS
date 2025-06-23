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
    public class OverTimesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OverTimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/OverTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OverTime>>> GetOverTimes()
        {
            return await _context.OverTimes.ToListAsync();
        }

        // GET: api/OverTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OverTime>> GetOverTime(string id)
        {
            var overTime = await _context.OverTimes.FindAsync(id);

            if (overTime == null)
            {
                return NotFound();
            }

            return overTime;
        }

        // PUT: api/OverTimes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOverTime(string id, OverTime overTime)
        {
            if (id != overTime.OverTimeID)
            {
                return BadRequest();
            }

            _context.Entry(overTime).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OverTimeExists(id))
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

        // POST: api/OverTimes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OverTime>> PostOverTime(OverTime overTime)
        {
            _context.OverTimes.Add(overTime);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OverTimeExists(overTime.OverTimeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOverTime", new { id = overTime.OverTimeID }, overTime);
        }

        // DELETE: api/OverTimes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOverTime(string id)
        {
            var overTime = await _context.OverTimes.FindAsync(id);
            if (overTime == null)
            {
                return NotFound();
            }

            _context.OverTimes.Remove(overTime);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OverTimeExists(string id)
        {
            return _context.OverTimes.Any(e => e.OverTimeID == id);
        }
    }
}
