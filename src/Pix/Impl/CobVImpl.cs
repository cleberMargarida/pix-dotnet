using PixDotNet.Models.CobV;
using PixDotNet.Models.Common;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class CobVImpl : CobPayloadImpl, ICobV
    {
        public CobVImpl(HttpClient httpClient) : base(httpClient) { }

        /// <inheritdoc/>
        public Task<CobVGerada> CreateCobVAsync(string txid, CobVBody body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobVGerada> GetCobVAsync(string txid, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobsVConsultadas> ListCobVAsync(ParametrosConsultaCob @params, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<CobVRevisada> ReviewCobVAsync(string txid, CobVBody body, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}