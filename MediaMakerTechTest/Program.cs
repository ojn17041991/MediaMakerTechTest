using MediaMakerTechTest.Data;
using MediaMakerTechTest.Data.Abstractions;
using MediaMakerTechTest.Models;
using Microsoft.EntityFrameworkCore;
using PostmanSandbox.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string? connectionString = builder.Configuration.GetConnectionString("Requests");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        connectionString
    )
);

builder.Services.AddTransient<IDataAccessor<Request>, DataAccessor>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthorization();

app.Run();
