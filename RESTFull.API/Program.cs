using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
//using MySql.EntityFrameworkCore.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(RESTFull.DTO.MapperProfile));
builder.Services.AddDbContext<RESTFull.Infrastructure.Context>(options =>
 options.UseMySql(builder.Configuration.GetConnectionString("Database3"),
                  new MySqlServerVersion(new Version(8, 0, 31))
                  )
 );

var app = builder.Build();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

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
