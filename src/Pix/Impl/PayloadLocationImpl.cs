using PixDotNet.Models.Common;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class PayloadLocationImpl : IPayloadLocation
    {
        private HttpClient httpClient;

        public PayloadLocationImpl(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        /// <inheritdoc/>
        public PayloadLocation CreatePayloadLocation(TipoCob tipoCob)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> CreatePayloadLocationAsync(TipoCob tipoCob, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public PayloadLocation DeletePayloadLocation(long id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> DeletePayloadLocationAsync(long id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public PayloadLocation GetPayloadLocation(long id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> GetPayloadLocationAsync(long id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public PayloadLocationConsultadas ListPayloadLocation(ParametrosConsultaPayloadLocation @params)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PayloadLocationConsultadas> ListPayloadLocationAsync(ParametrosConsultaPayloadLocation @params, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}