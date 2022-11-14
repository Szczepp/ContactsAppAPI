using System.Linq.Expressions;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ContactsAppAPI.Abstracts
{
    public interface IServiceBase<EntityType> where EntityType  : class
    {
        public Task<List<EntityType>> GetAllAsync();
        public Task<EntityType> GetByIdAsync(long entityId);
        public IEnumerable<EntityType> GetByCondition(Expression<Func<EntityType, bool>> expression);
        public void Create(EntityType entity);
        public void Update(EntityType entity);
        public void Delete(long entityId);
    }
}
