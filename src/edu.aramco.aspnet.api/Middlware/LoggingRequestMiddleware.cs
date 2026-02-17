using System.Diagnostics;

namespace edu.aramco.aspnet.api.Middlware;

public class LoggingRequestMiddleware(RequestDelegate next, 
    ILogger<LoggingRequestMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        EventLog.WriteEntry("SMS", $"Request Coming at {DateTime.Now}", EventLogEntryType.Information, 5000);

        //logger.LogError("New request is coming");
        //logger.LogWarning("New request is coming");
        //logger.LogTrace("New request is coming");
        //logger.LogInformation("New request is coming");


        var stopwatch = Stopwatch.StartNew();
        await next(context);
        var elapsedTime = stopwatch.ElapsedMilliseconds;

        //EventLog.WriteEntry("Aramco", $"Request has been executed in {DateTime.Now}", EventLogEntryType.Information, 101);
        EventLog.WriteEntry("Aramco", $"Request Ended at {DateTime.Now}", EventLogEntryType.Information, 5001);
    }
}
