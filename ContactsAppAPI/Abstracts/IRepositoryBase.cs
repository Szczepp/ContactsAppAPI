using ContactsAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ContactsAppAPI.Abstracts
{
    public interface IRepositoryBase<T> where T : class
    {
        public IQueryable<T> GetAll();
        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression);
        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
