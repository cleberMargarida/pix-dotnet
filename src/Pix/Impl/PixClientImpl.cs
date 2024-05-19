using PixDotNet.Models.Cob;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class PixClientImpl : IPixClient
    {
        private bool _disposedValue;
        internal readonly bool _skipClientDispose;
        internal readonly HttpClient _httpClient;
        internal readonly HttpClientHandler _httpHandler;

        public PixClientImpl()
        {
            _httpHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpHandler)
            {
                Timeout = TimeSpan.FromMinutes(1)
            };
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("Keep-Alive", "true");

            CobPayload = new CobPayloadImpl(_httpClient);
            Cob = new CobImpl(_httpClient);
            CobV = new CobVImpl(_httpClient);
            LoteCobV = new LoteCobVImpl(_httpClient);
            PayloadLocation = new PayloadLocationImpl(_httpClient);
            Pix = new PixImpl(_httpClient);
            Webhook = new WebhookImpl(_httpClient);
        }

        /// <inheritdoc/>
        public ICobPayload CobPayload { get; }

        /// <inheritdoc/>
        public ICob Cob { get; }

        /// <inheritdoc/>
        public ICobV CobV { get; }

        /// <inheritdoc/>
        public ILoteCobV LoteCobV { get; }

        /// <inheritdoc/>
        public IPayloadLocation PayloadLocation { get; }

        /// <inheritdoc/>
        public IPix Pix { get; }

        /// <inheritdoc/>
        public IWebhook Webhook { get; }

        /// <inheritdoc/>
        public Task<CobPayload> GetCobPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default)
        {
            return CobPayload.GetCobPayloadAsync(pixUrlAccessToken, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposedValue)
            {
                return;
            }
            if (disposing)
            {
                _httpClient?.Dispose(); 
                _httpHandler?.Dispose();
            }

            _disposedValue = true;
        }

        ~PixClientImpl()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
