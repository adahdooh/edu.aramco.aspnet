using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Quartz;
using Quartz.Logging;

namespace edu.aramco.aspnet.jobs.Jobs;

[DisallowConcurrentExecution]
public class SendEmailForUsersJob(ApplicationDbContext applicationDbContext,
    GraphServiceClient graphServiceClient,
    ILogger<SendEmailForUsersJob> logger) : IJob
{
    public async Task Execute(IJobExecutionContext context)
    {
        var exceptions = new List<Exception>();
        var cancellationToken = context.CancellationToken;

        var stopWatch = System.Diagnostics.Stopwatch.StartNew();
        logger.LogInformation($"{GetType().Name} has been triggered at {stopWatch}");

        var messages = await applicationDbContext.SMSs.Where(s => !s.IsProcessed)
            .ToListAsync(cancellationToken);

        foreach (var message in messages)
        {
            try
            {
                await ProcessRecord(message, cancellationToken);
                message.IsProcessed = true;
                await applicationDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                exceptions.Add(ex);
            }
        }

        if (exceptions.Any())
        {
            throw new AggregateException(exceptions);
        }

        logger.LogInformation($"{GetType().Name} has been executed at {stopWatch.Elapsed.TotalSeconds}");
    }

    private async Task ProcessRecord(SMS sms, CancellationToken cancellationToken)
    {
        // Send email logic here
        var requestBody = new Microsoft.Graph.Users.Item.SendMail.SendMailPostRequestBody
        {
            Message = new Message
            {
                Subject = "Message From Aramco",
                Body = new ItemBody
                {
                    ContentType = BodyType.Text,
                    Content = sms.PhoneNumber,
                },
                ToRecipients = [
                    new Recipient
                    {
                        EmailAddress = new EmailAddress
                        {
                            Address = sms.Body
                        }
                    }],
            },
            SaveToSentItems = false
        };
        await graphServiceClient
            .Users["akmal.eldahdouh@salic.com"]
            .SendMail
            .PostAsync(requestBody);

    }
}
