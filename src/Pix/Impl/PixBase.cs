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

        protected PutRequest<TIn> Put<TIn>(string url, TIn body, params string[] parameters)
        {
            return new PutRequest<TIn>(_httpClient, string.Format(url, parameters), body);
        }
        
        protected PutRequest<TIn, TOut> Put<TIn, TOut>(string url, TIn body, params string[] parameters)
        {
            return new PutRequest<TIn, TOut>(_httpClient, string.Format(url, parameters), body);
        }
        
        protected PutRequestOuter<TOut> Put<TOut>(string url, params string[] parameters)
        {
            return new PutRequestOuter<TOut>(_httpClient, string.Format(url, parameters));
        }

        protected PostRequest<TIn, TOut> Post<TIn, TOut>(string url, TIn body, params string[] parameters)
        {
            return new PostRequest<TIn, TOut>(_httpClient, string.Format(url, parameters), body);
        }

        protected PatchRequest<TIn> Patch<TIn>(string url, TIn body, params string[] parameters)
        {
            return new PatchRequest<TIn>(_httpClient, string.Format(url, parameters), body);
        }

        protected PatchRequest<TIn, TOut> Patch<TIn, TOut>(string url, TIn body, params string[] parameters)
        {
            return new PatchRequest<TIn, TOut>(_httpClient, string.Format(url, parameters), body);
        }

        protected DeleteRequest Delete(string url, params string[] parameters)
        {
            return new DeleteRequest(_httpClient, string.Format(url, parameters));
        }
    }
}
