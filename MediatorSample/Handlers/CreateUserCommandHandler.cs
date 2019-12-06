using System.Threading;
using System.Threading.Tasks;
using MediatorSample.Models;
using MediatR;

namespace MediatorSample.Handlers
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