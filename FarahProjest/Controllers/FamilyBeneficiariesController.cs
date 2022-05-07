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
    public class FamilyBeneficiariesController : ControllerBase
    {
        private readonly FarahContext _context;

        public FamilyBeneficiariesController(FarahContext context)
        {
            _context = context;
        }

        // GET: api/FamilyBeneficiaries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbFamilyBeneficiary>>> GetTbFamilyBeneficiaries()
        {
            return await _context.TbFamilyBeneficiaries.ToListAsync();
        }

        // GET: api/FamilyBeneficiaries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbFamilyBeneficiary>> GetTbFamilyBeneficiary(Guid id)
        {
            var tbFamilyBeneficiary = await _context.TbFamilyBeneficiaries.FindAsync(id);

            if (tbFamilyBeneficiary == null)
            {
                return NotFound();
            }

            return tbFamilyBeneficiary;
        }

        // PUT: api/FamilyBeneficiaries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbFamilyBeneficiary(Guid id, TbFamilyBeneficiary tbFamilyBeneficiary)
        {
            if (id != tbFamilyBeneficiary.FamilyBeneficiaryId)
            {
                return BadRequest();
            }

            _context.Entry(tbFamilyBeneficiary).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbFamilyBeneficiaryExists(id))
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

        // POST: api/FamilyBeneficiaries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbFamilyBeneficiary>> PostTbFamilyBeneficiary(TbFamilyBeneficiary tbFamilyBeneficiary)
        {
            _context.TbFamilyBeneficiaries.Add(tbFamilyBeneficiary);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbFamilyBeneficiaryExists(tbFamilyBeneficiary.FamilyBeneficiaryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbFamilyBeneficiary", new { id = tbFamilyBeneficiary.FamilyBeneficiaryId }, tbFamilyBeneficiary);
        }

        // DELETE: api/FamilyBeneficiaries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbFamilyBeneficiary(Guid id)
        {
            var tbFamilyBeneficiary = await _context.TbFamilyBeneficiaries.FindAsync(id);
            if (tbFamilyBeneficiary == null)
            {
                return NotFound();
            }

            _context.TbFamilyBeneficiaries.Remove(tbFamilyBeneficiary);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbFamilyBeneficiaryExists(Guid id)
        {
            return _context.TbFamilyBeneficiaries.Any(e => e.FamilyBeneficiaryId == id);
        }
    }
}
