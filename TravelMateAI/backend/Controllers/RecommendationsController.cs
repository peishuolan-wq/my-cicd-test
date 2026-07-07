using Microsoft.AspNetCore.Mvc;
using TravelMateAI.Models;

namespace TravelMateAI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class RecommendationsController : ControllerBase
{
    // TODO: inject IRecommendationService and replace hardcoded data with DB calls
    // private readonly IRecommendationService _svc;
    // public RecommendationsController(IRecommendationService svc) => _svc = svc;

    /// <summary>GET /api/recommendations — 首頁「為你推薦」清單</summary>
    [HttpGet]
    public ActionResult<IEnumerable<Recommendation>> GetAll()
    {
        // TODO: return await _svc.GetPersonalisedAsync(userId);
        var data = new List<Recommendation>
        {
            new() { Id=1, CityName="曼谷", Country="泰國",  Tag="熱門",    Rating=4.7 },
            new() { Id=2, CityName="釜山", Country="韓國",  Tag="CP值高",  Rating=4.8 },
            new() { Id=3, CityName="東京", Country="日本",  Tag="獨旅推薦",Rating=4.9 },
        };
        return Ok(data);
    }

    /// <summary>GET /api/recommendations/{id} — 單一城市詳情</summary>
    [HttpGet("{id:int}")]
    public ActionResult<Recommendation> GetById(int id)
    {
        // TODO: return await _svc.GetByIdAsync(id);
        return NotFound();
    }
}
