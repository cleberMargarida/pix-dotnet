using PixDotNet.Models.Cob;
using PixDotNet.Models.CobV;
using PixDotNet.Requests;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class CobPayloadImpl : PixBase, ICobPayload
    {
        public CobPayloadImpl(HttpClient httpClient) : base(httpClient) { }

        /// <inheritdoc/>
        public Task<CobPayload> GetCobPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default)
        {
            return Get<CobPayload>(pixUrlAccessToken).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, CancellationToken cancellationToken = default)
        {
            return Get<CobVPayload>("cobv/{0}", pixUrlAccessToken).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, string codMunicipio, CancellationToken cancellationToken = default)
        {
            return Get<CobVPayload>("cobv/{0}?codMun={1}", pixUrlAccessToken, codMunicipio).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, DateTime pagamentoData, CancellationToken cancellationToken = default)
        {
            return Get<CobVPayload>("cobv/{0}?DDP={1}", pixUrlAccessToken, pagamentoData.ToString("yyyy-MM-dd")).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobVPayload> GetCobVPayloadAsync(string pixUrlAccessToken, string codMunicipio, DateTime pagamentoData, CancellationToken cancellationToken = default)
        {
            return Get<CobVPayload>("cobv/{0}?codMun={1}&DDP={2}", pixUrlAccessToken, codMunicipio, pagamentoData.ToString("yyyy-MM-dd")).ExecuteAsync(cancellationToken);
        }
    }
}