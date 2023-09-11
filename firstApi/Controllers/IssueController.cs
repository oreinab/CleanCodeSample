using firstApi.Data;
using firstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace firstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _issueDbContext;

        public IssueController(IssueDbContext issueDbContext) => _issueDbContext = issueDbContext;

        [HttpGet]
        public async Task<IEnumerable<Issue>> Get()
        {
            return await _issueDbContext.Issues.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetBy(int id)
        {
            var issue = await _issueDbContext.Issues.FindAsync(id);
            return issue == null ? NotFound() : Ok(issue);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Issue issue)
        {
            await _issueDbContext.Issues.AddAsync(issue);
            await _issueDbContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBy), new { id = issue.Id }, issue);
        }

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Issue issue)
        {
            if (id != issue.Id)
            { return BadRequest(nameof(Issue)); }
            _issueDbContext.Entry(issue).State = EntityState.Modified;
            await _issueDbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public  IActionResult Delete(int id)
        {
            var deleteItem =  _issueDbContext.Issues.Find(id);
            if(deleteItem == null) return NotFound();
            _issueDbContext.Remove(deleteItem);
             _issueDbContext.SaveChanges();
            return NoContent();
        }

    }
}
