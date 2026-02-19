using edu.aramco.aspnet.api.Middlware;
using edu.aramco.aspnet.api.Models.Requests;
using edu.aramco.aspnet.api.Validators;
using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.scaffold.Models;
using edu.aramco.aspnet.services.IServices;
using edu.aramco.aspnet.services.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

builder.Services.AddDbContext<ApplicationDbContext>();

var zktConnectionString =
    builder.Configuration.GetConnectionString("ZKTConnection")
    ?? throw new InvalidOperationException("Connection string" + "'ZKTConnection' not found.");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(zktConnectionString)
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

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter JWT token ONLY (without 'Bearer ' prefix)"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

builder.Services.AddLogging(log =>
{
    log.ClearProviders();
    log.AddConsole();
#pragma warning disable CA1416 // Validate platform compatibility
    log.AddEventLog(new Microsoft.Extensions.Logging.EventLog.EventLogSettings
    {
        LogName = "Aramco",
        SourceName = "SMS",
        Filter = (source, level) => level >= LogLevel.Information
    });
#pragma warning restore CA1416 // Validate platform compatibility
});

var app = builder.Build();

//using (var scope = app.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//    var db1 = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

//    db.Database.Migrate();
//    db1.Database.Migrate();
//}

app.Use(async (context, next) =>
{
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
    logger.LogInformation("Handling request: {Method} {Path}", context.Request.Method, context.Request.Path);
    await next.Invoke();
    logger.LogInformation("Finished handling request.");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseMiddleware<LoggingRequestMiddleware>();
app.UseMiddleware<LoggingRequestMiddleware>();
app.UseMiddleware<LoggingRequestMiddleware>();
app.UseMiddleware<LoggingRequestMiddleware>();
app.UseMiddleware<LoggingRequestMiddleware>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
