using Microsoft.AspNetCore.Mvc;
using TravelMateAI.Models;

namespace TravelMateAI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TrendingController : ControllerBase
{
    // TODO: inject ITrendingService

    /// <summary>GET /api/trending — 側邊欄趨勢推薦景點</summary>
    [HttpGet]
    public ActionResult<IEnumerable<TrendingSpot>> GetAll()
    {
        // TODO: return await _svc.GetTodayTrendingAsync();
        var data = new List<TrendingSpot>
        {
            new()
            {
                Id       = 1,
                SpotName = "釜山海雲台",
                CityName = "釜山",
                Country  = "韓國・釜山廣域市",
            }
        };
        return Ok(data);
    }
}
