using Microsoft.EntityFrameworkCore;
using polyco.Application.Interfaces;
using polyco.Application.Services;
using polyco.Persistence.Data;
using polyco.Persistence.Interfaces;
using polyco.Persistence.Repos;

var builder = WebApplication.CreateBuilder(args);

var allowedOrigin = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

// Add services to the container.
builder.Services.AddDbContext<PolyCoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<ICustomersRepo, CustomersRepo>();
builder.Services.AddTransient<ICustomersService , CustomersService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PolyCoDbContext>();
    db.Database.Migrate();
}

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
