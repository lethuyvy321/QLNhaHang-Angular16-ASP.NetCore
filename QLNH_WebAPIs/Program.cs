using Microsoft.EntityFrameworkCore;
using QLNH_WebAPIs.Data;

var builder = WebApplication.CreateBuilder(args);
string mySQLServer = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContextPool<MyDbContext>(options => options.UseMySql
    (mySQLServer, ServerVersion.AutoDetect(mySQLServer)));
builder.Services.AddSwaggerGen();

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
