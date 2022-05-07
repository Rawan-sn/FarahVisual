using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FarahProjest.Models;

namespace FarahProjest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthlySalariesController : ControllerBase
    {
        private readonly FarahContext _context;

        public MonthlySalariesController(FarahContext context)
        {
            _context = context;
        }

        // GET: api/MonthlySalaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbMonthlySalary>>> GetTbMonthlySalaries()
        {
            return await _context.TbMonthlySalaries.ToListAsync();
        }

        // GET: api/MonthlySalaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbMonthlySalary>> GetTbMonthlySalary(Guid id)
        {
            var tbMonthlySalary = await _context.TbMonthlySalaries.FindAsync(id);

            if (tbMonthlySalary == null)
            {
                return NotFound();
            }

            return tbMonthlySalary;
        }

        // PUT: api/MonthlySalaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbMonthlySalary(Guid id, TbMonthlySalary tbMonthlySalary)
        {
            if (id != tbMonthlySalary.MonthlySalaryId)
            {
                return BadRequest();
            }

            _context.Entry(tbMonthlySalary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbMonthlySalaryExists(id))
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

        // POST: api/MonthlySalaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbMonthlySalary>> PostTbMonthlySalary(TbMonthlySalary tbMonthlySalary)
        {
            _context.TbMonthlySalaries.Add(tbMonthlySalary);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbMonthlySalaryExists(tbMonthlySalary.MonthlySalaryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbMonthlySalary", new { id = tbMonthlySalary.MonthlySalaryId }, tbMonthlySalary);
        }

        // DELETE: api/MonthlySalaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbMonthlySalary(Guid id)
        {
            var tbMonthlySalary = await _context.TbMonthlySalaries.FindAsync(id);
            if (tbMonthlySalary == null)
            {
                return NotFound();
            }

            _context.TbMonthlySalaries.Remove(tbMonthlySalary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbMonthlySalaryExists(Guid id)
        {
            return _context.TbMonthlySalaries.Any(e => e.MonthlySalaryId == id);
        }
    }
}
