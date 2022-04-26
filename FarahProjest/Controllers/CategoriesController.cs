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
    public class CategoriesController : ControllerBase
    {
        private readonly FarahContext _context;

        public CategoriesController(FarahContext context)
        {
            _context = context;
        }

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbCategory>>> GetTbCategories()
        {
            return await _context.TbCategories.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbCategory>> GetTbCategory(Guid id)
        {
            var tbCategory = await _context.TbCategories.FindAsync(id);

            if (tbCategory == null)
            {
                return NotFound();
            }

            return tbCategory;
        }

        // PUT: api/Categories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbCategory(Guid id, TbCategory tbCategory)
        {
            if (id != tbCategory.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(tbCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbCategoryExists(id))
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

        // POST: api/Categories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbCategory>> PostTbCategory(TbCategory tbCategory)
        {
            _context.TbCategories.Add(tbCategory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbCategoryExists(tbCategory.CategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbCategory", new { id = tbCategory.CategoryId }, tbCategory);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbCategory(Guid id)
        {
            var tbCategory = await _context.TbCategories.FindAsync(id);
            if (tbCategory == null)
            {
                return NotFound();
            }

            _context.TbCategories.Remove(tbCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbCategoryExists(Guid id)
        {
            return _context.TbCategories.Any(e => e.CategoryId == id);
        }
    }
}
