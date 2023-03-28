using Sample.Application.Interfaces;
using Sample.Infrastructure.Context;
using Sample.Infrastructure.Repositories;

namespace Sample.Infrastructure.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Users = new UserRepository(_dbContext);
        }

        public IUserRepository Users { get; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}