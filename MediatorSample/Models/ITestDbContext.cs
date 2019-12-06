using System.Collections.Generic;
using MediatorSample.Handlers;

namespace MediatorSample.Models
{
    public interface ITestDbContext
    {
        List<User> User { get; }

        void Create(User user);
    }
}