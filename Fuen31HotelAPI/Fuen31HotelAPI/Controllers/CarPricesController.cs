using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fuen31HotelAPI.Models;

namespace Fuen31HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricesController : ControllerBase
    {
        private readonly dbHotelContext _context;

        public CarPricesController(dbHotelContext context)
        {
            _context = context;
        }

        // GET: api/CarPrices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarPrice>>> GetCarPrices()
        {
            return await _context.CarPrices.ToListAsync();
        }

        // GET: api/CarPrices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarPrice>> GetCarPrice(int id)
        {
            var carPrice = await _context.CarPrices.FindAsync(id);

            if (carPrice == null)
            {
                return NotFound();
            }

            return carPrice;
        }

        // PUT: api/CarPrices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarPrice(int id, CarPrice carPrice)
        {
            if (id != carPrice.Id)
            {
                return BadRequest();
            }

            _context.Entry(carPrice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarPriceExists(id))
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

        // POST: api/CarPrices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarPrice>> PostCarPrice(CarPrice carPrice)
        {
            _context.CarPrices.Add(carPrice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarPrice", new { id = carPrice.Id }, carPrice);
        }

        // DELETE: api/CarPrices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarPrice(int id)
        {
            var carPrice = await _context.CarPrices.FindAsync(id);
            if (carPrice == null)
            {
                return NotFound();
            }

            _context.CarPrices.Remove(carPrice);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarPriceExists(int id)
        {
            return _context.CarPrices.Any(e => e.Id == id);
        }
    }
}
