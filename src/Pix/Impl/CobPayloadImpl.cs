using PixDotNet.Models.Cob;
using PixDotNet.Models.CobV;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class CobPayloadImpl : ICobPayload
    {
        private HttpClient httpClient;

        public CobPayloadImpl(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public CobPayload GetCobPayload(string pixUrlAccessToken)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobPayload> GetCobPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public CobVPayload GetCobVPayload(string pixUrlAccessToken, string? codMunicipio = null, DateTime? pagamentoData = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, string? codMunicipio = null, DateTime? pagamentoData = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}