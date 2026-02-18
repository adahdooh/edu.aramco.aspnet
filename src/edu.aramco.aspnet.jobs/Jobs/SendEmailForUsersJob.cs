using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using Quartz;
using Quartz.Logging;

namespace edu.aramco.aspnet.jobs.Jobs;

[DisallowConcurrentExecution]
public class SendEmailForUsersJob(ApplicationDbContext applicationDbContext,
    ILogger<SendEmailForUsersJob> logger) : IJob
{
    List<string> mesasges = new List<string>
    {
        "Message 1", "Message 2", "Message 3", "Message 4", "Message 5"
    };

    public async Task Execute(IJobExecutionContext context)
    {
        var exceptions = new List<Exception>();
        var cancellationToken = context.CancellationToken;

        var stopWatch = System.Diagnostics.Stopwatch.StartNew();
        logger.LogInformation($"{GetType().Name} has been triggered at {stopWatch}");

        foreach (var message in mesasges)
        {
            try
            {
                await ProcessRecord(message, cancellationToken);
            }
            catch (Exception ex)
            {
                exceptions.Add(ex);
            }
        }

        await applicationDbContext.SaveChangesAsync(cancellationToken);

        if (exceptions.Any())
        {
            throw new AggregateException(exceptions);
        }

        logger.LogInformation($"{GetType().Name} has been executed at {stopWatch.Elapsed.TotalSeconds}");
    }

    private async Task ProcessRecord(string message, CancellationToken cancellationToken)
    {
        await applicationDbContext.SMSs.AddAsync(new SMS
        {
            Body = message,
            PhoneNumber = "+1234567890"
        }, cancellationToken);
    }
}
