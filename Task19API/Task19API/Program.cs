using Microsoft.EntityFrameworkCore;
using Task19API.Data;
using Task19API.Interface;
using Task19API.Service;
using Task19API.Service.ConnectionService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// ���������� ��������
ConnectionService.ConnectService(builder);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddCors(c => c.AddPolicy("AllowOrigin", op => op.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

//����������� � ��
builder.Services.AddDbContext<DataContext>(op =>
{
    // ����� ��������� ����������� � ��
    op.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(op => op.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
