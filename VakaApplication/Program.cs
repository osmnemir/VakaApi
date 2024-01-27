using Microsoft.EntityFrameworkCore;
using VakaApplication.Data;
using VakaApplication.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<DataContext>(options=>options.UseInMemoryDatabase("EmployeesDb"));
builder.Services.AddDbContext<DataContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("EmpyoleesApiConnectionString")));
//builder.Services.AddTransient<ISalaryService, FixedSalaryService>();
//builder.Services.AddTransient<ISalaryService, OvertimeService>();
//builder.Services.AddTransient<ISalaryService, DailyRateService>();







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
