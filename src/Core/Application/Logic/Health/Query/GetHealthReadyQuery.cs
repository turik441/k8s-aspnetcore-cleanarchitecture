using Application.Responses.Health;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Logic.Health.Query
{
    public class GetHealthReadyQuery:IRequest<GetHealthResponse>
    {
        public GetHealthReadyQuery()
        {}
    }
    internal class GetHealthReadyQueryHandler : IRequestHandler<GetHealthReadyQuery, GetHealthResponse>
    {
        public Task<GetHealthResponse> Handle(GetHealthReadyQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetHealthResponse
            {
                Message = "Yes. Ready now."
            });
        }
    }
}
