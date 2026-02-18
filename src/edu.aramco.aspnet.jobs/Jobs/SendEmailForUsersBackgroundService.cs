using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Quartz;
using Quartz.Logging;

namespace edu.aramco.aspnet.jobs.Jobs;

public class SendEmailForUsersBackgroundService(ApplicationDbContext applicationDbContext,
    GraphServiceClient graphServiceClient,
    ILogger<SendEmailForUsersJob> logger) : BackgroundService
{
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
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var exceptions = new List<Exception>();

        while (!stoppingToken.IsCancellationRequested)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                return;
            }

            var stopWatch = System.Diagnostics.Stopwatch.StartNew();
            logger.LogInformation($"{GetType().Name} has been triggered at {stopWatch}");

            var messages = await applicationDbContext.SMSs.Where(s => !s.IsProcessed)
                .ToListAsync(stoppingToken);

            foreach (var message in messages)
            {
                try
                {
                    await ProcessRecord(message, stoppingToken);
                    message.IsProcessed = true;
                    await applicationDbContext.SaveChangesAsync(stoppingToken);
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
        }

        logger.LogInformation($"{GetType().Name} has been executed at {stopWatch.Elapsed.TotalSeconds}");
    }
}
