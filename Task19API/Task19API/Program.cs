using Microsoft.EntityFrameworkCore;
using Task19API.Data;
using Task19API.Service.ConnectionService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// ���������� ��������
ConnectionService.ConnectService(builder);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//����������� � ��
builder.Services.AddDbContext<DataContext>(op =>
{
    // ����� ��������� ����������� � ��
    op.UseNpgsql(builder.Configuration.GetConnectionString("EmployeeAppCon"));
});


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
