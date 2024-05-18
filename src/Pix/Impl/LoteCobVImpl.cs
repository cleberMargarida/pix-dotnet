using PixDotNet.Models.LoteCobV;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class LoteCobVImpl : ILoteCobV
    {
        private HttpClient httpClient;

        public LoteCobVImpl(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public void CriarOuAlterarCobV(long id, LoteCobVBody body)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task CriarOuAlterarCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public LoteCobVConsultado GetCobV(long id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<LoteCobVConsultado> GetCobVAsync(long id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public LotesCobVConsultados ListCobV(ParametrosConsultaLote body)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<LotesCobVConsultados> ListCobVAsync(ParametrosConsultaLote body, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public void ReviewCobV(long id, LoteCobVBody body)
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