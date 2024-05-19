using PixDotNet.Models.Common;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class PixImpl : IPix
    {
        private readonly HttpClient _httpClient;

        public PixImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public Task<Pix> GetPixAsync(string e2eid, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Devolucao> GetReturnedPixAsync(string e2eid, string id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PixConsultados> ListPixReceivedAsync(ParametrosConsultaPix @params, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<Devolucao> ReturnPixAsync(string e2eid, string id, decimal valor, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
