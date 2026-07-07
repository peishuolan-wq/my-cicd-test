namespace TravelMateAI.Models;

// ── 為你推薦 (Smart Picks) ──────────────────────────────────────────
public class Recommendation
{
    public int    Id         { get; set; }
    public string CityName   { get; set; } = string.Empty;
    public string Country    { get; set; } = string.Empty;
    public string? ImageUrl  { get; set; }
    public string? Tag       { get; set; }        // e.g. "熱門", "CP值高"
    public double? Rating    { get; set; }
    public string? Description { get; set; }
}

// ── 行程 (Trip / Continue Planning) ────────────────────────────────
public class Trip
{
    public int     Id              { get; set; }
    public string  Title           { get; set; } = string.Empty;
    public string  Subtitle        { get; set; } = string.Empty;  // "還有 N 個空檔尚未安排"
    public int     ProgressPercent { get; set; }                  // 0–100
    public string? ImageUrl        { get; set; }
    public string  Status          { get; set; } = "active";      // active | completed | archived
    public int     EmptySlots      { get; set; }
    public DateTime CreatedAt      { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt      { get; set; } = DateTime.UtcNow;
}

// ── 論壇貼文 (Forum Post) ───────────────────────────────────────────
public class ForumPost
{
    public int     Id          { get; set; }
    public string  Title       { get; set; } = string.Empty;
    public int     ReplyCount  { get; set; }
    public string  ReplyLabel  { get; set; } = string.Empty;   // "已有 N 人回覆・剛剛"
    public string? AvatarUrl   { get; set; }
    public string  AuthorName  { get; set; } = string.Empty;
    public DateTime PostedAt   { get; set; } = DateTime.UtcNow;
    public string  Category    { get; set; } = string.Empty;   // e.g. "找旅伴", "問路"
}

// ── 趨勢景點 (Trending Spot) ────────────────────────────────────────
public class TrendingSpot
{
    public int     Id          { get; set; }
    public string  SpotName    { get; set; } = string.Empty;   // "釜山海雲台"
    public string  CityName    { get; set; } = string.Empty;
    public string  Country     { get; set; } = string.Empty;
    public string? ImageUrl    { get; set; }
    public string? Description { get; set; }
}
