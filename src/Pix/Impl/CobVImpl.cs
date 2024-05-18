using PixDotNet.Models.CobV;
using PixDotNet.Models.Common;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class CobVImpl : ICobV
    {
        private HttpClient httpClient;

        public CobVImpl(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public CobVGerada CreateCobV(string txid, CobVBody body)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobVGerada> CreateCobVAsync(string txid, CobVBody body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public CobVGerada GetCobV(string txid)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobVGerada> GetCobVAsync(string txid, CancellationToken cancellationToken = default)
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

        /// <inheritdoc/>
        public CobsVConsultadas ListCobV(ParametrosConsultaCob @params)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobsVConsultadas> ListCobVAsync(ParametrosConsultaCob @params, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public CobVRevisada ReviewCobV(string txid, CobVBody body)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobVRevisada> ReviewCobVAsync(string txid, CobVBody body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}