using PixDotNet.Models.LoteCobV;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class LoteCobVImpl : PixBase, ILoteCobV
    {
        public LoteCobVImpl(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc/>
        public Task CriarOuAlterarCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default)
        {
            return Put<LoteCobVBody>("/lotecobv/{0}", body, id.ToString()).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<LoteCobVConsultado> GetCobVAsync(long id, CancellationToken cancellationToken = default)
        {
            return Get<LoteCobVConsultado>("/lotecobv/{0}", id.ToString()).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<LotesCobVConsultados> ListCobVAsync(ParametrosConsultaLote @params, CancellationToken cancellationToken = default)
        {
            return Get<LotesCobVConsultados>("/lotecobv?{0}", @params.ToQueryString()).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task ReviewCobVAsync(long id, LoteCobVBody body, CancellationToken cancellationToken = default)
        {
            return Patch<LoteCobVBody>("/lotecobv/{0}", body, id.ToString()).ExecuteAsync(cancellationToken);
        }
    }
}