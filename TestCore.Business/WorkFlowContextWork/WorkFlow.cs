using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Data.Context;
using TestCore.Repositories.Repository;

namespace TestCore.Business.WorkFlowContextWork
{
    public class WorkFlow<T> : IWorkFlow<T> where T : class
    {
        private  WorkFlowContext _context;

        public IRepository<T> Repo {get;}
        public WorkFlow(IConfiguration config)
        {
            var connection = config.GetConnectionString("MyConnStr");
            var optionsBuilder = new DbContextOptionsBuilder<WorkFlowContext>();
            optionsBuilder.UseSqlServer(connection).UseLazyLoadingProxies().EnableSensitiveDataLogging();
            _context =new WorkFlowContext(optionsBuilder.Options);
            Repo = new Repository<T>(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_context == null) return;
            _context.Dispose();
            _context = null;
        }
    }
}
