using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MediatorSample.Handlers
{
    public class QueryUserHandler : IRequestHandler<QueryUserQuery, QueryUserResponse>
    {
        public Task<QueryUserResponse> Handle(QueryUserQuery request, CancellationToken cancellationToken)
        {
        }
    }

    public class QueryUserResponse
    {
    }

    public class QueryUserQuery : IRequest<QueryUserResponse>
    {
        public int Id { get; set; }
    }
}