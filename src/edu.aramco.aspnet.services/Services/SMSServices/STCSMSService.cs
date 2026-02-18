using System;
using System.Collections.Generic;
using System.Text;
using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.domainEntities.Entities;
using edu.aramco.aspnet.services.IServices;

namespace edu.aramco.aspnet.services.Services
{
    public class STCSMSService : ISMSService
    {
        // Old style of injecting the service
        private readonly ApplicationDbContext applicationDbContext;

        public STCSMSService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public string Key => "STC";

        public Task<List<SMS>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task Send(
            string telephoneNumber,
            string body,
            CancellationToken cancellationToken
        )
        {
            await applicationDbContext.SMSs.AddAsync(
                new SMS { Body = body, PhoneNumber = telephoneNumber },
                cancellationToken
            );
        }
    }
}
