using System.Configuration;
using DevOpsApi.Model;
using DevOpsApi.Services;
using DevOpsExamApi.Model;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Add(new ServiceDescriptor(typeof(DBcontext), new DBcontext()));



var app = builder.Build();

Console.WriteLine("----------------------------------------running----------------------------------------");

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

