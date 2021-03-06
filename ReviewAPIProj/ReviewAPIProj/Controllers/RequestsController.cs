using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReviewAPIProj.Data;
using ReviewAPIProj.Models;

namespace ReviewAPIProj.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly ProjContext _context;

        public RequestsController(ProjContext context)
        {
            _context = context;
        }



        [HttpPut("{id}/rejected")]
        public async Task<IActionResult> PutRequestToReject(int id)
        {

            var req = await _context.Request.FindAsync(id);
            if (req == null) { return NotFound(); }

            req.Status = "REJECTED";

            _context.Entry(req).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();

        }



        [HttpPut("{id}/approve")]
        public async Task<IActionResult> PutRequestToApprove(int id)
        {

            var req = await _context.Request.FindAsync(id);
            if (req == null) { return NotFound(); }

            req.Status = "APPROVED";

            _context.Entry(req).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();

        }



        // PUT: api/Requests/5/review
        // To protect from overposting attacks, enable the specific properties you want to bind to, for

        [HttpPut("{id}/review")]
        public async Task<IActionResult> PutRequestToReviewOrApprove(int id)
        {

            var req = await _context.Request.FindAsync(id);
                if(req == null) { return NotFound(); }

            req.Status = (req.Total <= 50 && req.Total > 0) ? "APPROVED" : "REJECTED";

            _context.Entry(req).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();

        }




        // GET: api/Review/{userId}
        [HttpGet("review/{id}")]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequestByStatus(int id)
        {
            var request = await _context.Request.FindAsync(id);

            return await _context.Request
                .Where(r => r.Status == ReviewAPIProj.Models.Request.StatusReview && r.UserId != id)
                .Include(r => r.UserId)
                .ToListAsync();

           

        }


        //-------------------------------------------------------------------------------------------------------------
        // GET: api/Requests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequest()
        {
            return await _context.Request.ToListAsync();
        }

        // GET: api/Requests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var request = await _context.Request.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            return request;
        }

        // PUT: api/Requests/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRequest(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestExists(id))
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

        // POST: api/Requests
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequest(Request request)
        {
            _context.Request.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequest", new { id = request.Id }, request);
        }

        // DELETE: api/Requests/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Request>> DeleteRequest(int id)
        {
            var request = await _context.Request.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            _context.Request.Remove(request);
            await _context.SaveChangesAsync();

            return request;
        }

        private bool RequestExists(int id)
        {
            return _context.Request.Any(e => e.Id == id);
        }
    }
}
