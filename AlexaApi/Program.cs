using Microsoft.EntityFrameworkCore;
using AlexaApi.Models;
using AlexaApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AlexaDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 39))
));

builder.Services.AddScoped<EmployeeService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();
