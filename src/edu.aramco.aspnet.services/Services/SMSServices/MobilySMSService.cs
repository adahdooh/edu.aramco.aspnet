using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using edu.aramco.aspnet.services.IServices;

namespace edu.aramco.aspnet.services.Services.SMSServices;

public class MobilySMSService(ApplicationDbContext applicationDbContext) : ISMSService
{
    public string Key => "Mobily";

    public async Task Send(string telephoneNumber, string body, CancellationToken cancellationToken)
    {
        await applicationDbContext.SMSs.AddAsync(new SMS
        {
            Body = body,
            PhoneNumber = telephoneNumber
        }, cancellationToken);


    }
}
