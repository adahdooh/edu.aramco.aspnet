using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Abstractions;

namespace edu.aramco.aspnet.jobs
{
    public class GraphClientCredentialAuthProvider : IAuthenticationProvider
    {
        private readonly IConfidentialClientApplication _clientApplication;

        public GraphClientCredentialAuthProvider()
        {
            var azureAdOptions = new ConfidentialClientApplicationOptions
            {
                ClientId = "", // get from portal.azure.com
                ClientSecret ="", // get from portal.azure.com
                TenantId = "salic.onmicrosoft.com",
                Instance = "https://login.microsoftonline.com/"
            };

            _clientApplication = ConfidentialClientApplicationBuilder
                                    .CreateWithApplicationOptions(azureAdOptions)
                                    .Build();
        }

        public async Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
        {
            var authResult = await _clientApplication.AcquireTokenForClient(new[] { "https://graph.microsoft.com/.default" }).ExecuteAsync(cancellationToken);
            if (request.Headers.ContainsKey("Authorization"))
            {
                request.Headers["Authorization"] = new List<string> { $"Bearer {authResult.AccessToken}" };
            }
            else
            {
                request.Headers.Add("Authorization", $"Bearer {authResult.AccessToken}");
            }
        }
    }
}
