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
    public class AidBasketsController : ControllerBase
    {
        private readonly FarahContext _context;

        public AidBasketsController(FarahContext context)
        {
            _context = context;
        }

        // GET: api/AidBaskets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbAidBasket>>> GetTbAidBaskets()
        {
            return await _context.TbAidBaskets.ToListAsync();
        }

        // GET: api/AidBaskets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbAidBasket>> GetTbAidBasket(Guid id)
        {
            var tbAidBasket = await _context.TbAidBaskets.FindAsync(id);

            if (tbAidBasket == null)
            {
                return NotFound();
            }

            return tbAidBasket;
        }

        // PUT: api/AidBaskets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbAidBasket(Guid id, TbAidBasket tbAidBasket)
        {
            if (id != tbAidBasket.AidBasketId)
            {
                return BadRequest();
            }

            _context.Entry(tbAidBasket).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbAidBasketExists(id))
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

        // POST: api/AidBaskets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbAidBasket>> PostTbAidBasket(TbAidBasket tbAidBasket)
        {
            _context.TbAidBaskets.Add(tbAidBasket);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbAidBasketExists(tbAidBasket.AidBasketId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbAidBasket", new { id = tbAidBasket.AidBasketId }, tbAidBasket);
        }

        // DELETE: api/AidBaskets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbAidBasket(Guid id)
        {
            var tbAidBasket = await _context.TbAidBaskets.FindAsync(id);
            if (tbAidBasket == null)
            {
                return NotFound();
            }

            _context.TbAidBaskets.Remove(tbAidBasket);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbAidBasketExists(Guid id)
        {
            return _context.TbAidBaskets.Any(e => e.AidBasketId == id);
        }
    }
}
