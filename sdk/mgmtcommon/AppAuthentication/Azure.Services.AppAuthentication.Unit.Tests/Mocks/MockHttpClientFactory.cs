﻿using System;
using System.Net.Http;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Microsoft.Azure.Services.AppAuthentication.Unit.Tests.Mocks
{
    internal class MockHttpClientFactory : IHttpClientFactory
    {
        public HttpClient GetHttpClient()
        {
            throw new NotImplementedException();
        }
    }
}
