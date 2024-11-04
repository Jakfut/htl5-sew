using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _02_Messstation.Data;
using _02_Messstation.DTOs;
using _02_Messstation.Models;
using NuGet.Protocol;

namespace _02_Messstation
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesstationController : ControllerBase
    {
        private readonly MessstationContext _context;

        public MesstationController(MessstationContext context)
        {
            _context = context;
        }

        // GET: api/Messtation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetMessstationDto>>> GetMessstation()
        {
            return Ok(MessstationMapper.Map(_context.Messstation.Include(m => m.Messwerte)));
        }

        // GET: api/Messtation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetMessstationDto>> GetMessstation(int id)
        {
            var messstation = await _context.Messstation.Include(m => m.Messwerte).Where(m => m.Id == id).FirstOrDefaultAsync();

            if (messstation == null)
            {
                return NotFound();
            }

            return MessstationMapper.Map(messstation);
        }

        // PUT: api/Messtation/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMessstation(int id, Messstation messstation)
        {
            if (id != messstation.Id)
            {
                return BadRequest();
            }

            _context.Entry(messstation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MessstationExists(id))
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

        // POST: api/Messtation
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Messstation>> PostMessstation(Messstation messstation)
        {
            _context.Messstation.Add(messstation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMessstation", new { id = messstation.Id }, messstation);
        }
        
        [HttpPost("{id}/messwert")]
        public async Task<ActionResult<PostMesswertDto>> PostMesswert(int id, PostMesswertDto messwertDto)
        {
            var messstation = await _context.Messstation.FindAsync(id);
            if (messstation == null)
            {
                return NotFound();
            }

            var messwert = new Messwert
            {
                Wert = messwertDto.Wert,
                Einheit = messwertDto.Einheit,
                Messstation = messstation
            };
            _context.Messwert.Add(messwert);
            await _context.SaveChangesAsync();

            return Ok(GetMesswertMapper.Map(messwert));
        }

        // DELETE: api/Messtation/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessstation(int id)
        {
            var messstation = await _context.Messstation.FindAsync(id);
            if (messstation == null)
            {
                return NotFound();
            }

            _context.Messstation.Remove(messstation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MessstationExists(int id)
        {
            return _context.Messstation.Any(e => e.Id == id);
        }
    }
}
