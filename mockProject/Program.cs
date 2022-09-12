using AutoMapper;
using Microsoft.EntityFrameworkCore;
using mockProject.AutoMapper;
using mockProject.Interfaces;
using mockProject.Persistences.Mongo;
using mockProject.Persistences.Mssql;
using mockProject.Persistences.Utils;
using mockProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("BaseContext");

builder.Services.AddDbContext<BaseContext>(options => options.UseSqlServer(connectionString));


// Bu iþlemin adý IoC üzerinden dependency injection yapmak. IoC nedir niye kullanýrýz ne iþimize yarar.
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

// Add singleton add scoped gibi iki farklý method gördük. Scoped bazlý eklemek nedir Singleton eklemek nedir
builder.Services.AddSingleton<IMongoContext, BaseMongoContext>();

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new UserProfile());
    mc.AddProfile(new CustomerProfile());
    mc.AddProfile(new ProductProfile());
    mc.AddProfile(new OrderProfile());
});

builder.Services.AddSingleton(mappingConfig.CreateMapper());

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


