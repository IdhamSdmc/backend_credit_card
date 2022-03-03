using backend_credit_card.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend_credit_card.Properties
{

    [Route("api/[controller]")]
    [ApiController]
    public class CrediCardController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CrediCardController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<CrediCardController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listCeditCards = await _context.CreditCard.ToListAsync();
                return Ok(listCeditCards);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<CrediCardController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CrediCardController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreditCard value)
        {
            try
            {
                _context.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<CrediCardController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CreditCard value)
        {
            try
            {
                if(id != value.Id)
                {
                    return NotFound();
                }
                else
                {
                    _context.Update(value);
                    await _context.SaveChangesAsync();
                    return Ok(new { message = "Credit Card was updated successfully!!!" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<CrediCardController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var creditCard = await _context.CreditCard.FindAsync(id);
                if (creditCard == null)
                {
                    return NotFound();
                }
                _context.CreditCard.Remove(creditCard);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Credit Card was deleted successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
