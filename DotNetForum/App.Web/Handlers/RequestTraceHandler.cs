using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;

namespace App.Web.Handlers
{
    public class RequestTraceHandler: DelegatingHandler
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("TraceHandler");
        protected async override Task<HttpResponseMessage> SendAsync(
        HttpRequestMessage request,
        CancellationToken cancellationToken)
        {
            if (logger.IsInfoEnabled)
            {
                var requestMessage = request.ToString();

                string content = string.Empty;
                if (request.Method == HttpMethod.Post || request.Method == HttpMethod.Put)
                {
                    if (!request.RequestUri.AbsoluteUri.Contains("login"))
                    {
                        content = await request.Content.ReadAsStringAsync();
                    }
                }
                string authToken = string.Empty;
                if (request.Headers.Authorization != null)
                {
                    authToken = request.Headers.Authorization.ToString();
                }

                var message = "| request | " + request.Method.ToString() + " | " + request.RequestUri.ToString() + " | " + content.ToString() + " | " + authToken;
                logger.Info(message);
                // need to log the incoming request somehow.
            }
            
            var response = await base.SendAsync(request, cancellationToken);

            if (logger.IsInfoEnabled)
            {
                var message = "| response | " + response.StatusCode.ToString() + " | " + response.Content.ToString();
                logger.Info(message);
            }
            return response;
        }

    }
}
