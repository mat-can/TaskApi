using Microsoft.EntityFrameworkCore;
using TaskApi.Utils;

var builder = WebApplication.CreateBuilder(args);

/// Entity framework connection.
builder.Services.AddDbContext<TaskContext>(p => p.UseInMemoryDatabase("TaskDB"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
