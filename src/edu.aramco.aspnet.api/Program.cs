using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.api.Validators;
using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.services.IServices;
using edu.aramco.aspnet.services.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

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

var jwtSection = builder.Configuration.GetSection("Jwt");
var issuer = jwtSection["Issuer"];
var audience = jwtSection["Audience"];
var key = jwtSection["Key"]!;
var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

builder.Services
  .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
  .AddJwtBearer(options =>
  {
      options.TokenValidationParameters = new TokenValidationParameters
      {
          ValidateIssuer = true,
          ValidIssuer = issuer,

          ValidateAudience = true,
          ValidAudience = audience,

          ValidateIssuerSigningKey = true,
          IssuerSigningKey = signingKey,

          ValidateLifetime = true
      };
  });

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ASP.NET",
        Version = "v1"
    });

    options.AddSecurityDefinition(
                  "Bearer",
                  new OpenApiSecurityScheme
                  {
                      In = ParameterLocation.Header,
                      Description = "Please enter a valid token.",
                      Name = "Authorization",
                      Type = SecuritySchemeType.Http,
                      BearerFormat = "JWT",
                      Scheme = "Bearer",
                  }
              );

    options.AddSecurityRequirement(document => new() { [new OpenApiSecuritySchemeReference("Bearer", document)] = [] });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
