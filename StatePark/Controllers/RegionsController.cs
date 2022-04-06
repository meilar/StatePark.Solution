using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StatePark.Models;
using System;

namespace StatePark.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RegionsController : ControllerBase
  {
    private readonly StateParkContext _db;

    public RegionsController(StateParkContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Region>>> Get()
    {
      return await _db.Regions.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Region>> GetRegion(int id)
    {
      var thisRegion = await _db.Regions.FindAsync(id);
      if(thisRegion == null)
      {
        return NotFound();
      }
      return thisRegion;
    }

    [HttpPost]
    public async Task<ActionResult<Region>> Post(Region region)
    {
      _db.Regions.Add(region);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetRegion), new { id = region.RegionId }, region);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Region region)
    {
      if(id != region.RegionId)
      {
        return BadRequest();
      }
      _db.Entry(region).State = EntityState.Modified;
      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RegionExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return CreatedAtAction(nameof(GetRegion), new { id = region.RegionId }, region);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRegion(int id)
    {
      var region = await _db.Regions.FindAsync(id);
      if (region == null)
      {
        return NotFound();
      }
      _db.Regions.Remove(region);
      await _db.SaveChangesAsync();
      return NoContent();
    }

    private bool RegionExists(int id)
    {
      return _db.Regions.Any(r => r.RegionId == id);
    }
  }
}