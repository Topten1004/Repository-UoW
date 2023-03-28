using Sample.Application.Interfaces;
using Sample.Domain.Entities;
using Sample.Infrastructure.Context;

namespace Sample.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}