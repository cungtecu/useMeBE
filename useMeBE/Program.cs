using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using useMeBE.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints().AddSwaggerDocument();
builder.Services.AddAuthorization();
builder.Services.AddAuthentication();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<TestDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseAuthorization();

app.UseFastEndpoints()
    .UseSwaggerGen();

app.Run();
