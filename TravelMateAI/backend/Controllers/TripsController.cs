using Microsoft.AspNetCore.Mvc;
using TravelMateAI.Models;

namespace TravelMateAI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TripsController : ControllerBase
{
    // TODO: inject ITripService

    /// <summary>GET /api/trips/active — 繼續規劃：進行中的行程</summary>
    [HttpGet("active")]
    public ActionResult<IEnumerable<Trip>> GetActive()
    {
        // TODO: return await _svc.GetActiveByUserAsync(userId);
        var data = new List<Trip>
        {
            new()
            {
                Id              = 1,
                Title           = "釜山五日放鬆行",
                Subtitle        = "還有 2 個空檔尚未安排",
                ProgressPercent = 60,
                EmptySlots      = 2,
                Status          = "active",
            }
        };
        return Ok(data);
    }

    /// <summary>GET /api/trips — 我的所有行程</summary>
    [HttpGet]
    public ActionResult<IEnumerable<Trip>> GetAll()
    {
        // TODO: return await _svc.GetAllByUserAsync(userId);
        return Ok(new List<Trip>());
    }

    /// <summary>GET /api/trips/{id}</summary>
    [HttpGet("{id:int}")]
    public ActionResult<Trip> GetById(int id)
    {
        // TODO: return await _svc.GetByIdAsync(id);
        return NotFound();
    }

    /// <summary>POST /api/trips — 新建行程</summary>
    [HttpPost]
    public ActionResult<Trip> Create([FromBody] Trip trip)
    {
        // TODO: var created = await _svc.CreateAsync(trip);
        // return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        return StatusCode(501);
    }

    /// <summary>PUT /api/trips/{id} — 更新行程</summary>
    [HttpPut("{id:int}")]
    public IActionResult Update(int id, [FromBody] Trip trip)
    {
        // TODO: await _svc.UpdateAsync(id, trip);
        return NoContent();
    }

    /// <summary>DELETE /api/trips/{id} — 刪除行程</summary>
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        // TODO: await _svc.DeleteAsync(id);
        return NoContent();
    }
}
