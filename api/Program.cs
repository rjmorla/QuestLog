using api.Data;
using Microsoft.EntityFrameworkCore;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Connection string.
var connStrBuilder = new NpgsqlConnectionStringBuilder(
    builder.Configuration.GetConnectionString("DefaultConnection"))
    {
        Username = builder.Configuration["DbUsername"],
        Password = builder.Configuration["DbPassword"]
    };
var connection = connStrBuilder.ConnectionString;

builder.Services.AddDbContext<ApplicationDBContext>(options => {
    options.UseNpgsql(connection);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();