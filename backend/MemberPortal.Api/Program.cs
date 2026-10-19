using MemberPortal.Api.Repositories;
using MemberPortal.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Dependency Injection registrations
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<IMemberService, MemberService>();

var app = builder.Build();

app.MapControllers();

app.MapGet("/", () => "Member Portal API is running");

app.Run();
