using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApi.Utils;

var builder = WebApplication.CreateBuilder(args);

/// First build Entity framework connection.
//builder.Services.AddDbContext<TaskContext>(p => p.UseInMemoryDatabase("TaskDB"));
/// Oracle sql developer connection.
builder.Services.AddSqlServer<TaskContext>(builder.Configuration.GetConnectionString("CSTask"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

/// Then map the database.
app.MapGet("/dbconnection", async ([FromServices] TaskContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database in memory: " + dbContext.Database.IsInMemory());
});

app.MapGet("/api/tasks", async ([FromServices] TaskContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks.Include(p => p.Category).Where(p => p.TaskPriorities == TaskApi.Models.Priorities.Medium || p.TaskPriorities == TaskApi.Models.Priorities.High));
});

app.Run();
