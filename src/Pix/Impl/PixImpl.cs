using PixDotNet.Models.Common;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PixDotNet.Impl
{
    internal class PixImpl : PixBase, IPix
    {
        public PixImpl(HttpClient httpClient) : base(httpClient)
        {
        }

        /// <inheritdoc/>
        public Task<Pix> GetPixAsync(string e2eid, CancellationToken cancellationToken = default)
        {
            return Get<Pix>("/pix/{0}", e2eid).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<Devolucao> GetReturnedPixAsync(string e2eid, string id, CancellationToken cancellationToken = default)
        {
            return Get<Devolucao>("/pix/{0}/devolucao/{1}", e2eid, id).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<PixConsultados> ListPixReceivedAsync(ParametrosConsultaPix @params, CancellationToken cancellationToken = default)
        {
            return Get<PixConsultados>("/pix?{0}", @params.ToQueryString()).ExecuteAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public Task<Devolucao> ReturnPixAsync(string e2eid, string id, decimal valor, CancellationToken cancellationToken = default)
        {
            return Put<ValorPayload, Devolucao>("/pix/{0}/devolucao/{1}", new ValorPayload(valor), e2eid, id).ExecuteAsync(cancellationToken);
        }
    }
}
