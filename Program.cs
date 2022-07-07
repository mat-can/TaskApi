using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskApi.Models;
using TaskApi.Utils;

var builder = WebApplication.CreateBuilder(args);

/// First build Entity framework connection.
//builder.Services.AddDbContext<TaskContext>(p => p.UseInMemoryDatabase("TaskDB"));
/// Oracle sql developer connection.
builder.Services.AddSqlServer<TaskContext>(builder.Configuration.GetConnectionString("CSTask"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async ([FromServices] TaskContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database in memory: " + dbContext.Database.IsInMemory());
});

/// List of tasks endpoint.
app.MapGet("/api/tasks/getTasks", async ([FromServices] TaskContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks.Include(p => p.Category).Where(p => p.TaskPriorities == TaskApi.Models.Priorities.Medium || p.TaskPriorities == TaskApi.Models.Priorities.High));
});

/// Task insert endpoint.
app.MapPost("/api/tasks/insertTask", async ([FromServices] TaskContext dbContext, [FromBody] Tasks task) =>
{
    task.IdTask = Guid.NewGuid();
    task.CreateTime = DateTime.Now;
    await dbContext.AddAsync(task);
    await dbContext.SaveChangesAsync();
});

/// Category insert endpoint.
app.MapPost("/api/tasks/insertCategory", async ([FromServices] TaskContext dbContext, [FromBody] Category category) =>
{
    category.IdCategory = Guid.NewGuid();
    await dbContext.AddAsync(category);
    await dbContext.SaveChangesAsync();
});

/// Task update endpoint.
app.MapPut("/api/tasks/updateTask/{id}", async ([FromServices] TaskContext dbContext, [FromBody] Tasks task, [FromRoute] Guid id) =>
{
    var currentTask = dbContext.Tasks.Find(id);
    if (currentTask != null)
    {
        currentTask.IdCategory = task.IdCategory;
        currentTask.TaskPriorities = task.TaskPriorities;
        currentTask.Description = task.Description;
        currentTask.TaskState = task.TaskState;
        currentTask.TaskTime = task.TaskTime;
        currentTask.CloseTime = task.CloseTime;

        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

/// Category update endpoint.
app.MapPut("/api/tasks/updateCategory/{id}", async ([FromServices] TaskContext dbContext, [FromBody] Category category, [FromRoute] Guid id) =>
{
    var currentCategory = dbContext.Categories.Find(id);
    if (currentCategory != null)
    {
        currentCategory.IdCategory = category.IdCategory;
        currentCategory.Name = category.Name;
        currentCategory.Description = category.Description;
        currentCategory.Weight = category.Weight;

        await dbContext.SaveChangesAsync();
        return Results.Ok();
    }
    else
    {
        return Results.NotFound();
    }
});

app.Run();
