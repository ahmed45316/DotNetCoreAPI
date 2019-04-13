using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Repositories.Repository;

namespace TestCore.Business.IdentityServer4
{
    public interface IIdentityWork<T> : IDisposable where T : class
    {
        IRepository<T> Repo { get; }
        int SaveChanges();
    }
}
