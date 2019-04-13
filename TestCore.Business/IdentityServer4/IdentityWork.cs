using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Data.Context;
using TestCore.Repositories.Repository;

namespace TestCore.Business.IdentityServer4
{
    public class IdentityWork<T>:IIdentityWork<T> where T:class
    {
        private WorkFlowContext _context;
        public IRepository<T> Repo { get; }
        public IdentityWork(IConfiguration config)
        {
            var connection = config.GetConnectionString("IdentityServer4");
            //var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connection).EnableSensitiveDataLogging();
            //_context = new ApplicationDbContext(optionsBuilder.Options);
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
