using ContactsAppAPI.Data;
using ContactsAppAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ContactsAppAPI.Abstracts
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext _db;

        protected RepositoryBase(ApplicationDbContext db)
        {
            _db = db;
        }

        public void Create(T entity)
        {
            this._db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            this._db.Set<T>().Remove(entity);
            _db.SaveChanges();

        }

        public IQueryable<T> GetAll()
        {
            return this._db.Set<T>().AsNoTracking();
        }

        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return this._db.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this._db.Set<T>().Update(entity);
            _db.SaveChanges();

        }
    }
}
