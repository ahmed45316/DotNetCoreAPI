using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Data.Context;
using TestCore.Data.IdentityContext;
using TestCore.Repositories.Repository;

namespace TestCore.Business.Identity
{
    public class IdentityWork<T>:IIdentityWork<T> where T:class
    {
        private IdentityDbContext _context;
        public IRepository<T> Repo { get; }
        public IdentityWork(IConfiguration config)
        {
            var connection = config.GetConnectionString("IdentityServer4");
            var optionsBuilder = new DbContextOptionsBuilder<IdentityDbContext>();
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connection).EnableSensitiveDataLogging();
            _context = new IdentityDbContext(optionsBuilder.Options);
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
