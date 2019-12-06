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

        [HttpPost]
        public async Task<QueryUserResponse> Query(QueryUserQuery query)
        {
            QueryUserResponse response = await _mediator.Send(query);

            return response;
        }

        [HttpPost]
        public async Task<Unit> Create(CreateUserCommand command)
        {
            Unit response = await _mediator.Send(command);

            return response;
        }
    }
}