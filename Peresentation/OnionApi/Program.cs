using OnionPersistance;
using OnionAplication;
using OnionMapper;
using Microsoft.Extensions.DependencyInjection;
using OnionAplication.Exceptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var env = builder.Environment;
builder.Configuration.SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json",optional: false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json",optional:true);

builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddAplication();
builder.Services.AddAutoMappers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHendlingMiddlewear();

app.UseAuthorization();

app.MapControllers();

app.Run();
