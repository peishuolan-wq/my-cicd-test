using Microsoft.AspNetCore.Mvc;
using TravelMateAI.Models;

namespace TravelMateAI.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class ForumController : ControllerBase
{
    // TODO: inject IForumService

    /// <summary>GET /api/forum/posts?limit=3 — 論壇最新招募貼文</summary>
    [HttpGet("posts")]
    public ActionResult<IEnumerable<ForumPost>> GetPosts([FromQuery] int limit = 10)
    {
        // TODO: return await _svc.GetLatestAsync(limit);
        var data = new List<ForumPost>
        {
            new()
            {
                Id         = 1,
                Title      = "4/14 釜山找人吃烤肉！",
                ReplyCount = 3,
                ReplyLabel = "已有 3 人回覆・剛剛",
                AuthorName = "旅遊達人",
                Category   = "找旅伴",
                PostedAt   = DateTime.UtcNow.AddMinutes(-5),
            }
        };
        return Ok(data.Take(limit));
    }

    /// <summary>GET /api/forum/posts/{id}</summary>
    [HttpGet("posts/{id:int}")]
    public ActionResult<ForumPost> GetPostById(int id)
    {
        // TODO: return await _svc.GetByIdAsync(id);
        return NotFound();
    }

    /// <summary>POST /api/forum/posts — 發布新貼文</summary>
    [HttpPost("posts")]
    public ActionResult<ForumPost> CreatePost([FromBody] ForumPost post)
    {
        // TODO: var created = await _svc.CreateAsync(post);
        // return CreatedAtAction(nameof(GetPostById), new { id = created.Id }, created);
        return StatusCode(501);
    }
}
