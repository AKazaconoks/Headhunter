using Headhunter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Headhunter.Data;

namespace Headhunter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SkillSetController : ControllerBase
    {
        private readonly CandidatesContext _context;

        public SkillSetController(CandidatesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetSkillSets()
        {
            var skillSets = await _context.SkillSets.ToListAsync();
            return Ok(skillSets);
        }

        [HttpGet("candidate/{id}")]
        public async Task<IActionResult> GetSkillSetByCandidate(int id)
        {
            var skillSets = await _context.SkillSets.Where(p => p.CandidateId == id).ToListAsync();
            return skillSets.Count == 0 ? NotFound() : Ok(skillSets);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSkillSet(int id)
        {
            var skillSet = await _context.SkillSets.FirstOrDefaultAsync(p => p.CandidateId == id);
            return skillSet == null ? NotFound() : Ok(skillSet);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSkillSet([FromBody] SkillSet skillSet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SkillSets.Add(skillSet);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetSkillSet), new { id = skillSet.Id }, skillSet);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSkillSet(int id, [FromBody] SkillSet skillSet)
        {
            if (id != skillSet.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(skillSet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSkillSet(int id)
        {
            var skillSet = await _context.SkillSets.FindAsync(id);
            if (skillSet == null)
            {
                return NotFound();
            }

            _context.SkillSets.Remove(skillSet);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
