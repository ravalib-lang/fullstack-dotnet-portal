var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Member Portal API is running");

app.Run();
