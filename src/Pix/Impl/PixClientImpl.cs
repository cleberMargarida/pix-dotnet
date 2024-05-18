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
        private bool disposedValue;
        internal readonly bool _skipClientDispose;
        internal readonly HttpClient _httpClient;
        internal readonly HttpClientHandler _httpHandler;

        public PixClientImpl()
        {
            _httpHandler = new HttpClientHandler();
            _httpClient = new HttpClient(_httpHandler);
            _httpClient.Timeout = TimeSpan.FromMinutes(1);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("Keep-Alive", "true");
        }

        /// <inheritdoc/>
        public ICobPayload CobPayload => new CobPayloadImpl(_httpClient);

        /// <inheritdoc/>
        public ICob Cob => new CobImpl(_httpClient);

        /// <inheritdoc/>
        public ICobV CobV => new CobVImpl(_httpClient);

        /// <inheritdoc/>
        public ILoteCobV LoteCobV => new LoteCobVImpl(_httpClient);

        /// <inheritdoc/>
        public IPayloadLocation PayloadLocation => new PayloadLocationImpl(_httpClient);

        /// <inheritdoc/>
        public IPix Pix => new PixImpl(_httpClient);

        /// <inheritdoc/>
        public IWebhook Webhook => new WebhookImpl(_httpClient);

        /// <inheritdoc/>
        public CobPayload GetCobPayload(string pixUrlAccessToken)
        {
            return CobPayload.GetCobPayload(pixUrlAccessToken);
        }

        /// <inheritdoc/>
        public async Task<CobPayload> GetCobPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default)
        {
            return await CobPayload.GetCobPayloadAsync(pixUrlAccessToken, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposedValue)
            {
                return;
            }
            if (disposing)
            {
                _httpClient?.Dispose(); 
                _httpHandler?.Dispose();
            }

            disposedValue = true;
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
