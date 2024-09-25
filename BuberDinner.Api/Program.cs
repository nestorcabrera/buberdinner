using BuberDinner.Api.Filters;
using BuberDinner.Api.Middleware;
using BuberDinner.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
//builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlerFilterAttribute>());
builder.Services.AddControllers();

var app = builder.Build();

//app.UseMiddleware<ErrorHandlerMiddleware>();
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();
app.MapControllers();

app.Run();