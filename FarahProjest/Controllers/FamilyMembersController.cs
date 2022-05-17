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
    public class FamilyMembersController : ControllerBase
    {
        private readonly FarahContext _context;

        public FamilyMembersController(FarahContext context)
        {
            _context = context;
        }

        // GET: api/FamilyMembers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TbFamilyMember>>> GetTbFamilyMembers()
        {
            return await _context.TbFamilyMembers.ToListAsync();
        }

        // GET: api/FamilyMembers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TbFamilyMember>> GetTbFamilyMember(Guid id)
        {
            var tbFamilyMember = await _context.TbFamilyMembers.FindAsync(id);

            if (tbFamilyMember == null)
            {
                return NotFound();
            }

            return tbFamilyMember;
        }

        [HttpGet("myChildren/{FamilyId:Guid}")]
        public async Task<IEnumerable<TbFamilyMember>> GetMyChildren(Guid FamilyId)
        {
            var myChildren = _context.TbFamilyMembers.AsQueryable();

            if (myChildren == null)
            {
                return await myChildren.ToListAsync();
            }

            myChildren = _context.TbFamilyMembers.Where(i => i.FamilyBeneficiaryId == FamilyId && i.TypeMember == "Children");

            return await myChildren.ToListAsync();
        }


        [HttpGet("ChildCourse/{FamilyMemberId:Guid}")]
        public IActionResult GetChildCourse(Guid FamilyMemberId)
        {
            var data = _context.TbFamilyMembers.Where(m => m.FamilyMemberId == FamilyMemberId).Include(x => x.TbMemberCourses).ThenInclude(x => x.Course).Select(
             x => new
             {
                 Name = x.MemberName ,
                 BirthDate = x.BirthDate ,
                 Class = x.ClassMember ,
                 Age = x.Age ,
                 gender = x.Gender,
                 Courses = x.TbMemberCourses.Select(c => new
                 {
                     StatusCource = c.Course.Status,
                     StatusChildofCourse = c.Status,
                     NameCourse = c.Course.NameCourse ,
                     DescriptionCourse = c.Course.Description,
                     TargetCourse = c.Course.TargetCourse,
                     PlaceCourse = c.Course.Place,
                     StartDate = c.Course.StartDate ,
                     EndDate = c.Course.EndDate ,
                     Result = c.Result ,
                     ResultStatus = c.StatusResult ,
                    
                 } ).ToList()
             }
             ) ;
            return Ok(data);
        }
    

        [HttpGet("mother/{FamilyId:Guid}")]
        public async Task<IEnumerable<TbFamilyMember>> GetMother(Guid FamilyId)
        {
            var mother = _context.TbFamilyMembers.AsQueryable();

            if (mother == null)
            {
                return await mother.ToListAsync();
            }

            mother = _context.TbFamilyMembers.Where(i => i.FamilyBeneficiaryId == FamilyId && i.TypeMember == "Mother");

            return await mother.ToListAsync();
        }

        [HttpGet("MotherActivity/{FamilyMemberId:Guid}")]
        public IActionResult GetMotherActivity(Guid FamilyMemberId)
        {
            var data = _context.TbFamilyMembers.Where(m => m.FamilyMemberId == FamilyMemberId).Include(x => x.TbMemberActivities).ThenInclude(x => x.Activity).Select(
             x => new
             {
                 Name = x.MemberName,
                 BirthDate = x.BirthDate,
                 Class = x.ClassMember,
                 Age = x.Age,
                 gender = x.Gender,
                 Courses = x.TbMemberActivities.Select(c => new
                 {
                     StatusCource = c.Activity.Status,
                     StatusChildofActivity = c.Status,
                     NameActivity = c.Activity.NameActivity,
                     DescriptionActivity = c.Activity.Description,
                     TargetActivity = c.Activity.TargetActivity,
                     PlaceActivity = c.Activity.Place,
                     StartDate = c.Activity.StartDate,
                     EndDate = c.Activity.EndDate,
                     Result = c.Result,
                     ResultStatus = c.StatusResult,

                 }).ToList()
             }
             );
            return Ok(data);
        }





        // PUT: api/FamilyMembers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTbFamilyMember(Guid id, TbFamilyMember tbFamilyMember)
        {
            if (id != tbFamilyMember.FamilyMemberId)
            {
                return BadRequest();
            }

            _context.Entry(tbFamilyMember).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TbFamilyMemberExists(id))
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

        // POST: api/FamilyMembers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TbFamilyMember>> PostTbFamilyMember(TbFamilyMember tbFamilyMember)
        {
            _context.TbFamilyMembers.Add(tbFamilyMember);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TbFamilyMemberExists(tbFamilyMember.FamilyMemberId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTbFamilyMember", new { id = tbFamilyMember.FamilyMemberId }, tbFamilyMember);
        }

        // DELETE: api/FamilyMembers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTbFamilyMember(Guid id)
        {
            var tbFamilyMember = await _context.TbFamilyMembers.FindAsync(id);
            if (tbFamilyMember == null)
            {
                return NotFound();
            }

            _context.TbFamilyMembers.Remove(tbFamilyMember);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TbFamilyMemberExists(Guid id)
        {
            return _context.TbFamilyMembers.Any(e => e.FamilyMemberId == id);
        }
    }
}