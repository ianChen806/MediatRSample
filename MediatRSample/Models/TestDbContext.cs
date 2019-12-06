using System.Collections.Generic;
using MediatRSample.Handlers;

namespace MediatRSample.Models
{
    public class TestDbContext : ITestDbContext
    {
        public List<User> User => new List<User>
        {
            new User {Id = 1, Name = "Test"},
            new User {Id = 2, Name = "123"},
            new User {Id = 3, Name = "asd"},
        };

        public void Create(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}