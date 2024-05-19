using PixDotNet.Models.Cob;
using PixDotNet.Requests;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;

namespace PixDotNet.Impl
{
    internal abstract class PixBase
    {
        private readonly HttpClient _httpClient;

        protected PixBase(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        protected GetRequest<TOut> Get<TOut>(string path, params string[] parameters)
        {
            return new GetRequest<TOut>(_httpClient, string.Format(path, parameters));
        }
        
        protected GetRequest<TOut> Get<TOut>(string url)
        {
            return new GetRequest<TOut>(_httpClient, url);
        }

        protected PutRequest<TIn, TOut> Put<TIn, TOut>(string url, TIn body, params string[] parameters)
        {
            return new PutRequest<TIn, TOut>(_httpClient, string.Format(url, parameters), body);
        }
    }
}
