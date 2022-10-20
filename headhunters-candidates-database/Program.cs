using headhunters_candidates_database.Core.Models;
using headhunters_candidates_database.Core.Services;
using headhunters_candidates_database.Data;
using headhunters_candidates_database.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HeadhuntersCandidatesDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("head-hunters-candidates"));
});

builder.Services.AddScoped<IHeadhuntersCandidatesDbContext, HeadhuntersCandidatesDbContext>();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IEntityService<Candidate>, EntityService<Candidate>>();
builder.Services.AddScoped<IEntityService<Company>, EntityService<Company>>();
builder.Services.AddScoped<IEntityService<Position>, EntityService<Position>>();

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