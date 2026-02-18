using Quartz.Logging;

namespace edu.aramco.aspnet.jobs.Jobs
{
    public class BackgroundHostedService(ILogger<BackgroundHostedService> logger) : IHostedService
    {
        public async Task StartAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation($"{GetType().Name} has been triggered at {DateTime.Now}");
            await Execute();
        }

        private async Task Execute()
        {
            
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            logger.LogInformation($"{GetType().Name} is stopping at {DateTime.Now}");
            return Task.CompletedTask;
        }
    }
}
