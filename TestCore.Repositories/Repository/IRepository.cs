﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TestCore.Repositories.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(params object[] keys);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        T FirstOrDefault(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        void Add(T newEntity);
        void AddRange(IEnumerable<T> newEntities);
        void Update(T entity);
        void Update(T entity, object key);
        void Update(T originalEntity, T newEntity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        object GetKeyValue(T t);
        bool Contains(Expression<Func<T, bool>> predicate);
        string GetKeyField(Type type);
    }
}
