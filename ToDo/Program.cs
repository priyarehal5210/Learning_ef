using Microsoft.EntityFrameworkCore;
using ToDo.DataAccess;
using ToDo.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

#region DI Container
//for multiple implementation of interface default it will use last one.
builder.Services.AddScoped<IPerson, Persons>();
//builder.Services.AddScoped<IPerson, PersonTest>();

//keyed service
//builder.Services.AddKeyedScoped<IPerson, Persons>("person");
//builder.Services.AddKeyedScoped<IPerson, PersonTest>("persontest");
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => Results.Redirect("/swagger"));
app.Run();