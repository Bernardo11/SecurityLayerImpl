using SecurityLayerImpl.Domain.Contracts.Repositories;
using SecurityLayerImpl.Domain.Contracts.Services;
using SecurityLayerImpl.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Services
builder.Services.AddScoped<ISecurityService, ISecurityService>();

//Add Repositories
builder.Services.AddScoped<ISecurityRepository, SecurityRepository>();

//Add External Data API
builder.Services.AddSingleton<ISecurityRepository, SecurityRepository>();

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
