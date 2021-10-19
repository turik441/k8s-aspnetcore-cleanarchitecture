using Application.Responses.Health;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Logic.Health.Query
{
    public class GetHealthAliveQuery:IRequest<GetHealthResponse>
    {
        public GetHealthAliveQuery()
        { }
    }
    internal class GetHealthAliveQueryHandler : IRequestHandler<GetHealthAliveQuery, GetHealthResponse>
    {       

        public Task<GetHealthResponse> Handle(GetHealthAliveQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetHealthResponse
            {
                Message = "Alive.All is well."
            });
        }
    }
}
