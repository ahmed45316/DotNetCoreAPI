using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using TestCore.Repositories.Repository;

namespace TestCore.Repositories.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private DbContext _context;
        public IRepository<T> Repo { get; }
        public UnitOfWork(DbContext context)
        {
            _context = context;
            Repo = new Repository<T>(context);
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
