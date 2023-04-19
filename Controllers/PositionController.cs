using Headhunter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Headhunter.Data;

namespace Headhunter.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly CandidatesContext _context;

        public PositionController(CandidatesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPositions()
        {
            var positions = await _context.Positions.ToListAsync();
            return Ok(positions);
        }

        [HttpGet("company/{id}")]
        public async Task<IActionResult> GetPositionsByCompany(int id)
        {
            var positions = await _context.Positions.Where(p => p.CompanyId == id).ToListAsync();
            return positions.Count == 0 ? NotFound() : Ok(positions);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPosition(int id)
        {
            var position = await _context.Positions.FirstOrDefaultAsync(p => p.CompanyId == id);
            return position == null ? NotFound() : Ok(position);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePosition([FromBody] Position position)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Positions.Add(position);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPosition), new { id = position.Id }, position);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePosition(int id, [FromBody] Position position)
        {
            if (id != position.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(position).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePosition(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            if (position == null)
            {
                return NotFound();
            }

            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
