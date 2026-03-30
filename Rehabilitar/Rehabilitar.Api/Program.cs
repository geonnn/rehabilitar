using Microsoft.EntityFrameworkCore;
using Rehabilitar.Domain.Entities;
using Rehabilitar.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RehabilitarDbContext>(options =>
{
   options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")); 
});

builder.Services.AddIdentityCore<User>(options =>
{
   options.Password.RequireDigit = false;
   options.Password.RequiredLength = 6;
   options.Password.RequireNonAlphanumeric = false;
   options.Password.RequireUppercase = false; 
   options.Password.RequireLowercase = false; 
})
.AddRoles<Role>()
.AddEntityFrameworkStores<RehabilitarDbContext>();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
