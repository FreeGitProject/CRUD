using AutoMapper;
using CoreV1.Dapper;
using CoreV1.Service.Brand;
using CRUD.ProfileMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
#region AutoMapper
builder.Services.AddAutoMapper(typeof(Program)); var config = new MapperConfiguration(c => { c.AddProfile(new ProfileMapper()); });
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper); builder.Services.AddScoped<IMapper, Mapper>();
#endregion AutoMapper
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(options =>
{
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
});

builder.Services.AddScoped<IDapperRepository, DapperRepository>();
builder.Services.AddScoped<IBrandService, BrandService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
