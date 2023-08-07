using DietProgram.Core.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.Core.IBaseRepositories
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity? Create(TEntity entity);

        TEntity? Update(TEntity entity);

        bool Delete(TEntity entity);
        


        TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter);

        ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter);

        ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select,
                                                       Expression<Func<TEntity, bool>> where,
                                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                      params Expression<Func<TEntity, object>>[] inculudes);


    }
}
