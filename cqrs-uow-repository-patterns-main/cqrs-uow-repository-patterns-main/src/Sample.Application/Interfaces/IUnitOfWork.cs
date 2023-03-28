using System;

namespace Sample.Application.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository Users { get; }
        int Complete();
    }
}