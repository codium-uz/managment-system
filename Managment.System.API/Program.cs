using Managment.System.API.Extensions;
using Managment.System.API.Helpers;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllers(options =>
//{
//    options.Conventions.Add(
//        new RouteTokenTransformerConvention(
//            new ConfigurationApiUrlName()));
//});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddContext(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
