using PixDotNet.Models.Common;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class PayloadLocationImpl : PixBase, IPayloadLocation
    {
        public PayloadLocationImpl(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> CreatePayloadLocationAsync(TipoCob tipoCob, CancellationToken cancellationToken = default)
        {
            return Post<TipoCobPayload, PayloadLocation>("/loc", new TipoCobPayload(tipoCob)).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task DeletePayloadLocationAsync(string txId, CancellationToken cancellationToken = default)
        {
            return Delete("/loc/{0}/txid", txId).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> GetPayloadLocationAsync(string txId, CancellationToken cancellationToken = default)
        {
            return Get<PayloadLocation>("/loc/{0}", txId).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<PayloadLocationConsultadas> ListPayloadLocationAsync(ParametrosConsultaPayloadLocation @params, CancellationToken cancellationToken = default)
        {
            return Get<PayloadLocationConsultadas>("/loc?{0}", @params.ToQueryString()).ExecuteAsync(cancellationToken);
        }
    }
}
