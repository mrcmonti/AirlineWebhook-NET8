using AirlineWeb.Data;
using AirlineWeb.MessageBus;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AirlineDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AIrlineWebConnection"));
});

builder.Services.AddAutoMapper(typeof(Program).Assembly);



builder.Services.AddSingleton<IMessageBusClient, MessageBusClient>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();


app.UseAuthorization();

app.MapControllers();

app.Run();
