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
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobSolicitada> GetCobAsync(string txid, int? revisao = null, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobsConsultadas> ListCobAsync(ParametrosConsultaCob payload, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobRevisada> ReviewCobAsync(string txid, CobBody body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}