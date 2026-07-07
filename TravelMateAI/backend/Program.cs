using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title   = "TravelMate AI API",
        Version = "v1",
        Description = "旅遊行程規劃後端 API",
    });
});

// CORS — 允許前端 (開發時開放全部 origin)
builder.Services.AddCors(opt =>
    opt.AddDefaultPolicy(p =>
        p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

// TODO: 注入各 Service / Repository
// builder.Services.AddScoped<IRecommendationService, RecommendationService>();
// builder.Services.AddScoped<ITripService, TripService>();
// builder.Services.AddScoped<IForumService, ForumService>();
// builder.Services.AddDbContext<AppDbContext>(opt =>
//     opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();
app.MapControllers();
app.Run();
