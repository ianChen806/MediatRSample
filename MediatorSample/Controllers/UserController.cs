using System.Threading.Tasks;
using MediatorSample.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSample.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<QueryUserResponse> Query(QueryUserQuery query)
        {
            var response = await _mediator.Send(query);

            return response;
        }
    }
}