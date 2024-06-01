using PixDotNet.Models.Cob;
using PixDotNet.Models.Common;
using PixDotNet.Requests;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class CobImpl : PixBase, ICob
    {
        public CobImpl(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc/>
        public Task<CobGerada> CreateCobAsync(string txid, CobBody body, CancellationToken cancellationToken = default)
        {
            return Put<CobBody, CobGerada>("/cob/{0}", body, txid).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobGerada> CreateCobAsync(CobBody body, CancellationToken cancellationToken = default)
        {
            return Post<CobBody, CobGerada>("/cob", body).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobSolicitada> GetCobAsync(string txid, CancellationToken cancellationToken = default)
        {
            return Get<CobSolicitada>("/cob/{0}", txid).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobSolicitada> GetCobAsync(string txid, int revisao, CancellationToken cancellationToken = default)
        {
            return Get<CobSolicitada>("/cob/{0}?revisao={1}", txid).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobsConsultadas> ListCobAsync(ParametrosConsultaCob payload, CancellationToken cancellationToken = default)
        {
            return Get<CobsConsultadas>("/cob?{0}", payload.ToQueryString()).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<CobRevisada> ReviewCobAsync(string txid, CobBody body, CancellationToken cancellationToken = default)
        {
            return Patch<CobBody, CobRevisada>("/cob/{0}", body, txid).ExecuteAsync(cancellationToken);
        }
    }
}