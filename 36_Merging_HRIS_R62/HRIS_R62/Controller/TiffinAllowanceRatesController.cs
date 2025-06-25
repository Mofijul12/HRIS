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
    public class TiffinAllowanceRatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TiffinAllowanceRatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TiffinAllowanceRates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TiffinAllowanceRate>>> GetTiffinAllowanceRates()
        {
            return await _context.TiffinAllowanceRates.ToListAsync();
        }

        // GET: api/TiffinAllowanceRates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TiffinAllowanceRate>> GetTiffinAllowanceRate(string id)
        {
            var tiffinAllowanceRate = await _context.TiffinAllowanceRates.FindAsync(id);

            if (tiffinAllowanceRate == null)
            {
                return NotFound();
            }

            return tiffinAllowanceRate;
        }

        // PUT: api/TiffinAllowanceRates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiffinAllowanceRate(string id, TiffinAllowanceRate tiffinAllowanceRate)
        {
            if (id != tiffinAllowanceRate.TiffinAllowanceRateID)
            {
                return BadRequest();
            }

            _context.Entry(tiffinAllowanceRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiffinAllowanceRateExists(id))
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

        // POST: api/TiffinAllowanceRates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TiffinAllowanceRate>> PostTiffinAllowanceRate(TiffinAllowanceRate tiffinAllowanceRate)
        {
            _context.TiffinAllowanceRates.Add(tiffinAllowanceRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TiffinAllowanceRateExists(tiffinAllowanceRate.TiffinAllowanceRateID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTiffinAllowanceRate", new { id = tiffinAllowanceRate.TiffinAllowanceRateID }, tiffinAllowanceRate);
        }

        // DELETE: api/TiffinAllowanceRates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiffinAllowanceRate(string id)
        {
            var tiffinAllowanceRate = await _context.TiffinAllowanceRates.FindAsync(id);
            if (tiffinAllowanceRate == null)
            {
                return NotFound();
            }

            _context.TiffinAllowanceRates.Remove(tiffinAllowanceRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TiffinAllowanceRateExists(string id)
        {
            return _context.TiffinAllowanceRates.Any(e => e.TiffinAllowanceRateID == id);
        }
    }
}
