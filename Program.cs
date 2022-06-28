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

app.Run();
