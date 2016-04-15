using System;
using System.Linq;
using System.Linq.Expressions;
using Business.Interface;
using System.Data.Entity;
using Data.Context;

namespace Business.Repository
{
    public abstract class GenericRepository<TEntity> :
        IGenericRepository<TEntity> where TEntity : class
    {

        #region Constructor

        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.set = context.Set<TEntity>();
        }

        #endregion

        #region Properties

        DbContext context;
        protected virtual DbContext Context
        {
            get
            {
                return context;
            }
        }

        DbSet<TEntity> set;
        protected virtual DbSet<TEntity> Set
        {
            get
            {
                return set;
            }
        }
        
        #endregion


        #region Methods

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = context.Set<TEntity>();
            return query;
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            IQueryable<TEntity> query = context.Set<TEntity>().Where(predicate);
            return query;
        }

        public void Add(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }

        public void Edit(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #endregion



    }
}
