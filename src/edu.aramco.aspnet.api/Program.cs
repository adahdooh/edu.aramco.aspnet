using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.api.Validators;
using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.services.IServices;
using edu.aramco.aspnet.services.Services;
using edu.aramco.aspnet.services.Services.SMSServices;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string" + "'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
);

// for both 1 and 2 ways of accessing the services, we need to register all the implementations of ISMSService
//builder.Services.AddScoped<ISMSService, MobilySMSService>();
//builder.Services.AddScoped<ISMSService, STCSMSService>();
//builder.Services.AddScoped<ISMSService, ZainSMSService>();

// using keyed access to the services
//builder.Services.AddKeyedScoped<ISMSService, MobilySMSService>("Mobily");
//builder.Services.AddKeyedScoped<ISMSService, STCSMSService>("STC");
//builder.Services.AddKeyedScoped<ISMSService, ZainSMSService>("Zain");

builder.Services.AddTransient<ISMSService, ZainSMSService>();

builder.Services.AddScoped<IValidator<CourseRequestModel>, CourseRequestModelValidator>();

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
