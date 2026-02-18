using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.jobs;
using edu.aramco.aspnet.jobs.Jobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Quartz;

var builder = WebApplication.CreateBuilder(args);

var connectionString =
    builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string" + "'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)
);

builder.Services.AddQuartz(s =>
{
    s.AddJob<SendEmailForUsersJob>(sendEmailForUsersJob => sendEmailForUsersJob.WithIdentity("SendEmailForUsersJob"))
     .AddTrigger(opts => opts
        .ForJob("SendEmailForUsersJob")
        .WithIdentity("SendEmailForUsersJob-trigger")
        .WithSimpleSchedule(x => x.WithIntervalInSeconds(10).RepeatForever()));
});

builder.Services.AddQuartzHostedService(x =>
{
    x.AwaitApplicationStarted = true;
    x.WaitForJobsToComplete = true;
});
builder.Services.AddScoped<GraphClientCredentialAuthProvider>();
builder.Services.AddScoped(provider =>
{
    var authProvider = provider.GetRequiredService<GraphClientCredentialAuthProvider>();
    return new GraphServiceClient(authProvider);
});

var app = builder.Build();

app.Run();