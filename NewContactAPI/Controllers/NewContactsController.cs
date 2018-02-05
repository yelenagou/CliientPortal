using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CaseContact.Models;
using NewContactAPI.Data;

namespace NewContactAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/NewContacts")]
    public class NewContactsController : Controller
    {
        private readonly NewContactDbContext _context;

        public NewContactsController(NewContactDbContext context)
        {
            _context = context;
        }

        // GET: api/NewContacts
        [HttpGet]
        public IEnumerable<NewContact> GetNewContact()
        {
            return _context.NewContact;
        }

        // GET: api/NewContacts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewContact([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newContact = await _context.NewContact.SingleOrDefaultAsync(m => m.Id == id);

            if (newContact == null)
            {
                return NotFound();
            }

            return Ok(newContact);
        }

        // PUT: api/NewContacts/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewContact([FromRoute] Guid id, [FromBody] NewContact newContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != newContact.Id)
            {
                return BadRequest();
            }

            _context.Entry(newContact).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewContactExists(id))
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

        // POST: api/NewContacts
        [HttpPost]
        public async Task<IActionResult> PostNewContact([FromBody] NewContact newContact)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.NewContact.Add(newContact);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewContact", new { id = newContact.Id }, newContact);
        }

        // DELETE: api/NewContacts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNewContact([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newContact = await _context.NewContact.SingleOrDefaultAsync(m => m.Id == id);
            if (newContact == null)
            {
                return NotFound();
            }

            _context.NewContact.Remove(newContact);
            await _context.SaveChangesAsync();

            return Ok(newContact);
        }

        private bool NewContactExists(Guid id)
        {
            return _context.NewContact.Any(e => e.Id == id);
        }
    }
}