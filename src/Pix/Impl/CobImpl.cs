using PixDotNet.Models.Cob;
using PixDotNet.Models.Common;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class CobImpl : ICob
    {
        private HttpClient httpClient;

        public CobImpl(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public CobGerada CreateCob(string txid, CobBody body)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public CobGerada CreateCob(CobBody body)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobGerada> CreateCobAsync(string txid, CobBody body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobGerada> CreateCobAsync(CobBody body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public CobSolicitada GetCob(string txid, int? revisao = null)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobSolicitada> GetCobAsync(string txid, int? revisao = null, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public CobsConsultadas ListCob(ParametrosConsultaCob payload)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobsConsultadas> ListCobAsync(ParametrosConsultaCob payload, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public CobRevisada ReviewCob(string txid, CobBody body)
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