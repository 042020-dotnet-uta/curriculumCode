using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FrigAPI.Models;

namespace FrigAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrigFoodsController : ControllerBase
    {
        private readonly FrigItemDbContext _context;

        public FrigFoodsController(FrigItemDbContext context)
        {
            _context = context;
        }

        // GET: api/FrigFoods
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FrigFood>>> GetFrigFoods()
        {
            return await _context.FrigFoods.ToListAsync();
        }

        // GET: api/FrigFoods/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FrigFood>> GetFrigFood(int id)
        {
            var frigFood = await _context.FrigFoods.FindAsync(id);

            if (frigFood == null)
            {
                return NotFound();
            }

            return frigFood;
        }

        // PUT: api/FrigFoods/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFrigFood(int id, FrigFood frigFood)
        {
            if (id != frigFood.FrigFoodId)
            {
                return BadRequest();
            }

            _context.Entry(frigFood).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FrigFoodExists(id))
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

        // POST: api/FrigFoods
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FrigFood>> PostFrigFood(FrigFood frigFood)
        {
            _context.FrigFoods.Add(frigFood);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetFrigFood", new { id = frigFood.FrigFoodId }, frigFood);
            return CreatedAtAction(nameof(GetFrigFood), new { id = frigFood.FrigFoodId }, frigFood);

        }

        // DELETE: api/FrigFoods/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FrigFood>> DeleteFrigFood(int id)
        {
            var frigFood = await _context.FrigFoods.FindAsync(id);
            if (frigFood == null)
            {
                return NotFound();
            }

            _context.FrigFoods.Remove(frigFood);
            await _context.SaveChangesAsync();

            return frigFood;
        }

        private bool FrigFoodExists(int id)
        {
            return _context.FrigFoods.Any(e => e.FrigFoodId == id);
        }

    }
}
