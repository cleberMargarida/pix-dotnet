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
//    /// Performs a PUT to API endpoints in Consul, returning a generic type
//    /// </summary>
//    /// <typeparam name="TOut">A generic type to be deserialised and returned</typeparam>
//    public class PutReturningRequest<TOut> : RequestBase
//    {
//        public WriteOptions Options { get; set; }

//        public PutReturningRequest(HttpClient client, string url) : base(client, url, HttpMethod.Put)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }

//        }

//        /// <summary>
//        /// Execute the PUT request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the PUT, including a deserialised generic type object</returns>
//        public async Task<TOut> Execute(CancellationToken cancellationToken)
//        {
//            Client.CheckDisposed();
//            var timer = Stopwatch.StartNew();
//            var result = new TOut();

//            var message = new HttpRequestMessage(HttpMethod.Put, BuildConsulUri(Endpoint, Params));
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

//            if (response.IsSuccessStatusCode)
//            {
//                result.Response = Deserialize<TOut>(ResponseStream);
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

//    /// <summary>
//    /// Performs a PUT to API endpoints in Consul
//    /// </summary>
//    public class PutNothingRequest : RequestBase
//    {
//        public WriteOptions Options { get; set; }

//        public PutNothingRequest(HttpClient client, string url) : base(client, url, HttpMethod.Put)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }

//        }

//        /// <summary>
//        /// Execute the PUT request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the PUT</returns>
//        public async Task<WriteResult> Execute(CancellationToken cancellationToken)
//        {
//            Client.CheckDisposed();
//            var timer = Stopwatch.StartNew();
//            var result = new WriteResult();

//            var message = new HttpRequestMessage(HttpMethod.Put, BuildConsulUri(Endpoint, Params));
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

//    /// <summary>
//    /// Performs a PUT to API endpoints in Consul, sending a generic type
//    /// </summary>
//    /// <typeparam name="TIn">A generic type to be serialised and sent</typeparam>
//    public class PutRequest<TIn> : RequestBase
//    {
//        public WriteOptions Options { get; set; }
//        private readonly TIn _body;

//        public PutRequest(HttpClient client, string url, TIn body) : base(client, url, HttpMethod.Put)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }
//            _body = body;

//        }

//        /// <summary>
//        /// Execute the PUT request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the PUT</returns>
//        public async Task<WriteResult> Execute(CancellationToken cancellationToken)
//        {
//            Client.CheckDisposed();
//            var timer = Stopwatch.StartNew();
//            var result = new WriteResult();

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

//            var message = new HttpRequestMessage(HttpMethod.Put, BuildConsulUri(Endpoint, Params));
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

//    /// <summary>
//    /// Performs a PUT to API endpoints in Consul, sending and returning generic types
//    /// </summary>
//    /// <typeparam name="TIn">A generic type to be serialised and sent</typeparam>
//    /// <typeparam name="TOut">A generic type to be deserialised and returned</typeparam>
//    public class PutRequest<TIn, TOut> : RequestBase
//    {
//        public WriteOptions Options { get; set; }
//        private readonly TIn _body;

//        public PutRequest(HttpClient client, string url, TIn body) : base(client, url, HttpMethod.Put)
//        {
//            if (string.IsNullOrEmpty(url))
//            {
//                throw new ArgumentException(null, nameof(url));
//            }
//            _body = body;

//        }

//        /// <summary>
//        /// Execute the PUT request to the API
//        /// </summary>
//        /// <param name="ct">Cancellation token for long poll request. If set, OperationCanceledException will be thrown if the request is cancelled before completing</param>
//        /// <returns>The result of the PUT, including a deserialised generic type object</returns>
//        public async Task<TOut> Execute(CancellationToken cancellationToken)
//        {
//            Client.CheckDisposed();
//            var timer = Stopwatch.StartNew();
//            var result = new TOut();

//            HttpContent content = null;

//            if (typeof(TIn) == typeof(byte[]))
//            {
//                var bodyBytes = _body as byte[];
//                if (bodyBytes != null)
//                {
//                    content = new ByteArrayContent(bodyBytes);
//                }
//                // If body is null and should be a byte array, then just don't send anything.
//            }
//            else
//            {
//                content = new ByteArrayContent(Serialize(_body));
//            }

//            var message = new HttpRequestMessage(HttpMethod.Put, BuildConsulUri(Endpoint, Params));
//            ApplyHeaders(message, Client.Config);
//            message.Content = content;
//            var response = await Client.HttpClient.SendAsync(message, ct);

//            result.StatusCode = response.StatusCode;

//            ResponseStream = await response.Content.ReadAsStreamAsync();

//            if (!response.IsSuccessStatusCode && (
//                (response.StatusCode != HttpStatusCode.NotFound && typeof(TOut) != typeof(TxnResponse)) ||
//                (response.StatusCode != HttpStatusCode.Conflict && typeof(TOut) == typeof(TxnResponse))))
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

//            if (response.IsSuccessStatusCode ||
//                // Special case for KV txn operations
//                (response.StatusCode == HttpStatusCode.Conflict && typeof(TOut) == typeof(TxnResponse)))
//            {
//                result.Response = Deserialize<TOut>(ResponseStream);
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
