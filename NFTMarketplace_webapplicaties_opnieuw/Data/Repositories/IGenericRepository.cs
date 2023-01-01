using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace NFTMarketplace_webapplicaties_opnieuw.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetById(int id);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        public bool Any(Expression<Func<TEntity, bool>> predicate);
    }
}
