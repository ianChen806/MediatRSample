using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MediatRSample.Models;

namespace MediatRSample.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand>
    {
        private readonly ITestDbContext _dbContext;

        public CreateUserCommandHandler(ITestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            _dbContext.Create(new User()
            {
                Name = request.Name
            });

            return Task.FromResult(Unit.Value);
        }
    }

    public class CreateUserCommand : IRequest<Unit>
    {
        public string Name { get; set; }
    }
}