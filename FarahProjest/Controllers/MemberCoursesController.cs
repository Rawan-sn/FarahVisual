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
    public class MemberCoursesController : ControllerBase
    {
        private readonly FarahContext _context;

        public MemberCoursesController(FarahContext context)
        {
            _context = context;
        }

        // GET: api/MemberCourses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbMemberCourse>>> GetTbMemberCourses()
        {
            return await _context.TbMemberCourses.ToListAsync();
        }

        // GET: api/MemberCourses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbMemberCourse>> GetTbMemberCourse(Guid id)
        {
            var tbMemberCourse = await _context.TbMemberCourses.FindAsync(id);

            if (tbMemberCourse == null)
            {
                return NotFound();
            }

            return tbMemberCourse;
        }

        // PUT: api/MemberCourses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbMemberCourse(Guid id, TbMemberCourse tbMemberCourse)
        {
            if (id != tbMemberCourse.MemberCourseId)
            {
                return BadRequest();
            }

            _context.Entry(tbMemberCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbMemberCourseExists(id))
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

        // POST: api/MemberCourses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbMemberCourse>> PostTbMemberCourse(TbMemberCourse tbMemberCourse)
        {
            _context.TbMemberCourses.Add(tbMemberCourse);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbMemberCourseExists(tbMemberCourse.MemberCourseId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbMemberCourse", new { id = tbMemberCourse.MemberCourseId }, tbMemberCourse);
        }

        // DELETE: api/MemberCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbMemberCourse(Guid id)
        {
            var tbMemberCourse = await _context.TbMemberCourses.FindAsync(id);
            if (tbMemberCourse == null)
            {
                return NotFound();
            }

            _context.TbMemberCourses.Remove(tbMemberCourse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbMemberCourseExists(Guid id)
        {
            return _context.TbMemberCourses.Any(e => e.MemberCourseId == id);
        }
    }
}
