using Contracts;
using UrlModifier.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// add services for buisness logic in regards to url encoding and decoding

builder.Services.AddSingleton<IUrlLogic, UrlLogic>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
