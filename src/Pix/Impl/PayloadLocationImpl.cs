using PixDotNet.Models.Common;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class PayloadLocationImpl : IPayloadLocation
    {
        private readonly HttpClient _httpClient;

        public PayloadLocationImpl(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> CreatePayloadLocationAsync(TipoCob tipoCob, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> DeletePayloadLocationAsync(long id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<PayloadLocation> GetPayloadLocationAsync(long id, CancellationToken cancellationToken = default)
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