using System;
using System.Collections.Generic;
using System.Text;

namespace edu.aramco.aspnet.services.IServices
{
    public interface ISMSService
    {
        /// <summary>
        /// Service to send SMS.
        /// </summary>
        /// <param name="telephoneNumber">the destination telephone number</param>
        /// <param name="body">the body of the message to be sent</param>
        /// <param name="cancellationToken"></param>
        /// <returns>Nothing</returns>
        Task Send(string telephoneNumber, string body, CancellationToken cancellationToken);
    }
}
