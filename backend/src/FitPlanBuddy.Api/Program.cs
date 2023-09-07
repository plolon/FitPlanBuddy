using FitPlanBuddy.Application.IoC;
using FitPlanBuddy.Database.IoC;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//    .AddJsonOptions(opt =>
//{
//    opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
//    opt.JsonSerializerOptions.WriteIndented = true;
//});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.RegisterDatabaseServices(builder.Configuration);
builder.Services.RegisterApplicationServices();

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
