using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Repositories.Repository;

namespace TestCore.Repositories.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        IRepository<T> Repo { get; }
        int SaveChanges();
    }
}
