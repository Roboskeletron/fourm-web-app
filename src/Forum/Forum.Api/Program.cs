using Forum.Api;
using Forum.Api.Middlewares;
using Forum.Application;
using Forum.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(configuration)
    .AddApiServices(configuration);

builder.Services.AddControllers();
builder.Services.AddSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler();

app.UseAuthentication();
app.UseMiddleware<UserProviderInitiatorMiddleware>();
app.UseAuthorization();

app.MapControllers();

app.Run();
