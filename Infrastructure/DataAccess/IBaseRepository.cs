using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public interface IBaseRepository<TEntity>
        where TEntity : class,IEntity
    {

         List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, params string[] includeList);
         TEntity Get(Expression<Func<TEntity, bool>> predicate, params string[] includeList);

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
