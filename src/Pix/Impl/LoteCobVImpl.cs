using PixDotNet.Models.LoteCobV;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class LoteCobVImpl : ILoteCobV
    {
        private readonly HttpClient _httpClient;

        public LoteCobVImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public Task CriarOuAlterarCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<LoteCobVConsultado> GetCobVAsync(long id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<LotesCobVConsultados> ListCobVAsync(ParametrosConsultaLote body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task ReviewCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}