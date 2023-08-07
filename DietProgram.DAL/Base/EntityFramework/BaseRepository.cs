using DietProgram.Core.BaseEntities;
using DietProgram.Core.Enums;
using DietProgram.Core.IBaseRepositories;
using DietProgram.DAL.Concrete.Context;
using DietProgram.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DietProgram.DAL.Base.EntityFramework
{
    public abstract class BaseRepository<TEntity, TContext> :
        IBaseRepository<TEntity>
        where TEntity : BaseEntity
        where TContext : DbContext
    {

        private DietProgramDbContext _context;



        protected readonly TContext _db;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseRepository(TContext context)
        {
            _db = context;
            _dbSet = _db.Set<TEntity>();
            _context = new DietProgramDbContext();

            if (_context==null)
            {
                _context = new DietProgramDbContext();
            }


        }

        public TEntity? Create(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Added;

            return _db.SaveChanges() > 0 ? entity : null;
        }

        public bool Delete(TEntity entity)
        {
            bool hasProperty = HasOwnProperty(typeof(TEntity), "DeleteDate");

            //if (!hasProperty)
            //{
            //    entity.State = State.Deleted;
            //    TEntity statedEntity = Update(entity);
            //    return statedEntity != null ? true : false;
            //}
            
            
                _db.Entry(entity).State = EntityState.Deleted;
                _db.Remove(entity);
                return _db.SaveChanges() > 0;
            
        }

        private bool HasOwnProperty(Type entityType, string propertyName)
        {
            var properties = entityType.GetProperties();
            bool hasproperty = properties.Any(p => p.Name == propertyName);
            return hasproperty;
        }



        public ICollection<TEntity>? GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public ICollection<TResult>? GetFilteredList<TResult>(Expression<Func<TEntity, TResult>> select, Expression<Func<TEntity, bool>> where, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, params Expression<Func<TEntity, object>>[] inculudes)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (inculudes != null)
            {
                query = query.MyIncludes(inculudes);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }

        public TEntity? GetFirstOrDefault(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.FirstOrDefault(filter);
        }

        public TEntity? Update(TEntity entity)
        {
            //_db.Entry(entity).State = EntityState.Modified;
            //return _db.SaveChanges() > 0 ? entity : null;
            _db.Update(entity);
            
           return _db.SaveChanges() > 0 ? entity : null ;
        }

        
        

    }
}
