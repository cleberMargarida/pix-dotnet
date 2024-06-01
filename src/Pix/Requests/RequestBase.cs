using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PixDotNet.Requests
{
    public abstract class RequestBase
    {
        internal readonly JsonSerializer _serializer = new JsonSerializer();

        internal RequestBase(HttpClient client, string url) : this(client, url, null)
        {
        }

        internal RequestBase(HttpClient client, string url, object? body)
        {
            Client = client;
            Endpoint = url;
            Body = body;
        }

        internal HttpClient Client { get; }
        internal string Endpoint { get; }
        internal object? Body { get; }

        protected TOut Deserialize<TOut>(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return _serializer.Deserialize<TOut>(jsonReader)!;
            }
        }

        protected static byte[] Serialize(object value)
        {
            var json = JsonConvert.SerializeObject(value);
            return Encoding.UTF8.GetBytes(json);
        }

        protected async Task<TOut> HandleResponseAsync<TOut>(HttpResponseMessage response)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();

            if (responseStream == null)
            {
                throw new PixRequestException(string.Format("Unexpected response, status code {0}", response.StatusCode), response.StatusCode);
            }

            if (response.IsSuccessStatusCode)
            {
                return Deserialize<TOut>(responseStream);
            }

            using (var sr = new StreamReader(responseStream))
            {
                throw new PixRequestException(string.Format("Unexpected response, status code {0}: {1}", response.StatusCode, await sr.ReadToEndAsync()), response.StatusCode);
            }
        }

        protected async Task HandleResponseAsync(HttpResponseMessage response)
        {
            using var responseStream = await response.Content.ReadAsStreamAsync();

            if (responseStream == null)
            {
                throw new PixRequestException(string.Format("Unexpected response, status code {0}", response.StatusCode), response.StatusCode);
            }

            if (response.IsSuccessStatusCode)
            {
                return;
            }

            using (var sr = new StreamReader(responseStream))
            {
                throw new PixRequestException(string.Format("Unexpected response, status code {0}: {1}", response.StatusCode, await sr.ReadToEndAsync()), response.StatusCode);
            }
        }
    }
}