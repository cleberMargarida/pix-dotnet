//using PixDotNet.Requests;
//using System;
//using System.Diagnostics;
//using System.IO;
//using System.Net;
//using System.Net.Http;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Consul
//{
//    /// <summary>
//    /// Performs a DELETE to API endpoints in Consul, returning a generic type
//    /// </summary>
//    /// <typeparam name="TOut">A generic type to be deserialised and returned</typeparam>
//    public class DeleteReturnRequest<TOut> : RequestBase
//    {
//        public DeleteReturnRequest(HttpClient client, string url) : base(client, url, HttpMethod.Delete)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }
//        }

//        /// <summary>
//        /// Execute the DELETE request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the DELETE, including a deserialised generic type object</returns>
//        public async Task<TOut> Execute(CancellationToken cancellationToken)
//        {
//            var message = new HttpRequestMessage(HttpMethod.Delete, Endpoint);
//            var response = await Client.SendAsync(message, ct);
//            ResponseStream = await response.Content.ReadAsStreamAsync();

//            if (response.IsSuccessStatusCode)
//            {
//                return Deserialize<TOut>(ResponseStream);
//            }

//            if (ResponseStream == null)
//            {
//                throw new PixRequestException(string.Format("Unexpected response, status code {0}",
//                    response.StatusCode), response.StatusCode);
//            }

//            using (var sr = new StreamReader(ResponseStream))
//            {
//                throw new PixRequestException(string.Format("Unexpected response, status code {0}: {1}",
//                    response.StatusCode, sr.ReadToEnd()), response.StatusCode);
//            }
//        }
//    }

//    /// <summary>
//    /// Performs a DELETE to API endpoints in Consul
//    /// </summary>
//    public class DeleteRequest : RequestBase
//    {
//        public DeleteRequest(HttpClient client, string url) : base(client, url, HttpMethod.Delete)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }
//        }

//        /// <summary>
//        /// Execute the DELETE request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the DELETE</returns>
//        public async Task<WriteResult> Execute(CancellationToken cancellationToken)
//        {
//            Client.CheckDisposed();
//            var timer = Stopwatch.StartNew();
//            var result = new WriteResult();

//            var message = new HttpRequestMessage(HttpMethod.Delete, BuildConsulUri(Endpoint, Params));
//            ApplyHeaders(message, Client.Config);
//            var response = await Client.HttpClient.SendAsync(message, ct);

//            result.StatusCode = response.StatusCode;

//            ResponseStream = await response.Content.ReadAsStreamAsync();

//            if (response.StatusCode != HttpStatusCode.NotFound && !response.IsSuccessStatusCode)
//            {
//                if (ResponseStream == null)
//                {
//                    throw new PixRequestException(string.Format("Unexpected response, status code {0}",
//                        response.StatusCode), response.StatusCode);
//                }
//                using (var sr = new StreamReader(ResponseStream))
//                {
//                    throw new PixRequestException(string.Format("Unexpected response, status code {0}: {1}",
//                        response.StatusCode, sr.ReadToEnd()), response.StatusCode);
//                }
//            }

//            result.RequestTime = timer.Elapsed;
//            return result;
//        }
//    }

//    /// <summary>
//    /// Performs a DELETE to API endpoints in Consul
//    /// </summary>
//    /// <typeparam name="TIn">A generic type to be serialised and sent with the DELETE</typeparam>
//    public class DeleteAcceptingRequest<TIn> : RequestBase
//    {
//        public WriteOptions Options { get; set; }
//        private readonly TIn _body;

//        public DeleteAcceptingRequest(HttpClient client, string url, TIn body) : base(client, url, HttpMethod.Delete)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }
//            _body = body;

//        }

//        /// <summary>
//        /// Execute the DELETE request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the DELETE</returns>
//        public async Task<WriteResult> Execute(CancellationToken cancellationToken)
//        {
//            Client.CheckDisposed();
//            var result = new WriteResult();
//            var timer = Stopwatch.StartNew();

//            HttpContent content;

//            if (typeof(TIn) == typeof(byte[]))
//            {
//                content = new ByteArrayContent((_body as byte[]) ?? Array.Empty<byte>());
//            }
//            else if (typeof(TIn) == typeof(Stream))
//            {
//                content = new StreamContent((_body as Stream) ?? new MemoryStream());
//            }
//            else
//            {
//                content = new ByteArrayContent(Serialize(_body));
//            }

//            var message = new HttpRequestMessage(HttpMethod.Delete, BuildConsulUri(Endpoint, Params));
//            ApplyHeaders(message, Client.Config);
//            message.Content = content;

//            var response = await Client.HttpClient.SendAsync(message, ct);

//            result.StatusCode = response.StatusCode;

//            ResponseStream = await response.Content.ReadAsStreamAsync();

//            if (response.StatusCode != HttpStatusCode.NotFound && !response.IsSuccessStatusCode)
//            {
//                if (ResponseStream == null)
//                {
//                    throw new PixRequestException(string.Format("Unexpected response, status code {0}",
//                        response.StatusCode), response.StatusCode);
//                }
//                using (var sr = new StreamReader(ResponseStream))
//                {
//                    throw new PixRequestException(string.Format("Unexpected response, status code {0}: {1}",
//                        response.StatusCode, sr.ReadToEnd()), response.StatusCode);
//                }
//            }

//            result.RequestTime = timer.Elapsed;
//            return result;
//        }

//        protected override void ApplyOptions(HttpClientConfiguration clientConfig)
//        {
//            if (Options == WriteOptions.Default)
//            {
//                return;
//            }

//            if (!string.IsNullOrEmpty(Options.Namespace))
//            {
//                Params["ns"] = Options.Namespace;
//            }

//            if (!string.IsNullOrEmpty(Options.Datacenter))
//            {
//                Params["dc"] = Options.Datacenter;
//            }
//        }

//        protected override void ApplyHeaders(HttpRequestMessage message, HttpClientConfiguration clientConfig)
//        {
//            if (!string.IsNullOrEmpty(Options.Token))
//            {
//                message.Headers.Add("X-Consul-Token", Options.Token);
//            }
//        }
//    }

//}
