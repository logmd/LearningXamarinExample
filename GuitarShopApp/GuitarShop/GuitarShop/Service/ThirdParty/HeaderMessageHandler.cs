﻿using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GuitarShop.Service.ThirdParty
{
    internal class HeaderMessageHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage message, CancellationToken token)
        {
            // Do any pre-request requirements here
            message.Headers.Add("X-Custom-Header", "Header Value");

            // Request happens here
            var response = await base.SendAsync(message, token);

            // Do any post-request requirements here
            return response;
        }

        // In your mobile client code:
        
    }
}