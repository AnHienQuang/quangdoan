using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyGhiDanh.Data;

namespace QuanLyGhiDanh.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoMonsController : ControllerBase
    {
        private readonly QuanLyGhiDanhContext _context;

        public BoMonsController(QuanLyGhiDanhContext context)
        {
            _context = context;
        }

        // GET: api/BoMons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoMon>>> GetBoMons()
        {
            return await _context.BoMons.ToListAsync();
        }

        // GET: api/BoMons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoMon>> GetBoMon(int id)
        {
            var boMon = await _context.BoMons.FindAsync(id);

            if (boMon == null)
            {
                return NotFound();
            }

            return boMon;
        }

        // PUT: api/BoMons/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoMon(int id, BoMon boMon)
        {
            if (id != boMon.IdBoMon)
            {
                return BadRequest();
            }

            _context.Entry(boMon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoMonExists(id))
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

        // POST: api/BoMons
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BoMon>> PostBoMon(BoMon boMon)
        {
            _context.BoMons.Add(boMon);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoMon", new { id = boMon.IdBoMon }, boMon);
        }

        // DELETE: api/BoMons/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBoMon(int id)
        {
            var boMon = await _context.BoMons.FindAsync(id);
            if (boMon == null)
            {
                return NotFound();
            }

            _context.BoMons.Remove(boMon);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BoMonExists(int id)
        {
            return _context.BoMons.Any(e => e.IdBoMon == id);
        }
    }
}
