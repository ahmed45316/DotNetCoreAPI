using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Repositories.Repository;

namespace TestCore.Business.WorkFlowContextWork
{
    public interface IWorkFlow<T>:IDisposable where T:class
    {
        IRepository<T> Repo { get; }
        int SaveChanges();
    }
}
