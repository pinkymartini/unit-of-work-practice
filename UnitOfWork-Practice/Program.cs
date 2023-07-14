using UnitOfWork_Practice.PersonServices;
using UnitOfWork_Practice.Repository;
using UnitOfWork_Practice.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using UnitOfWork_Practice.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<DatabaseContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));



builder.Services.AddTransient<IPersonService, PersonService>();
builder.Services.AddTransient<IGenericRepository, GenericRepository>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUnitOfWorkFactory, UnitOfWorkFactory>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
