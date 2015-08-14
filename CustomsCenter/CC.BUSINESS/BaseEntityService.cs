using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using CC.EF;
using CC.MODELS;

namespace CC.BUSINESS
{

    public abstract class BaseEntityService : IDisposable
    {
        protected AppContext Context;

        protected BaseEntityService(AppContext context)
        {
            Context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) {
                if (Context != null) {
                    Context.Dispose();
                    Context = null;
                }
            }
        }
    }

    public abstract class BaseEntityService<TModel> : BaseEntityService where TModel : class
    {
        protected IDbSet<TModel> DbSet { get; set; }

        protected BaseEntityService(AppContext context) : base(context)
        {
            DbSet = Context.Set<TModel>();
        }

        public virtual List<TModel> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public virtual TModel Find(int id)
        {
            return DbSet.Find(id);
        }

        public virtual TModel Create(TModel newEntity)
        {
            newEntity = DbSet.Add(newEntity);
            Context.SaveChanges();

            return newEntity;
        }

        public virtual TModel Update(TModel entity)
        {
            Context.SaveChanges( );

            return entity;
        }

        public virtual void Remove(int id)
        {
            var entity = Find(id);

            DbSet.Remove(entity);
            Context.SaveChanges();
        }
    }


    public abstract class SoftDeleteEntityService<TModel> : BaseEntityService<TModel>
        where TModel : class, IDeletedEntity
    {
        protected SoftDeleteEntityService(AppContext context) : base(context)
        {
        }

        public override List<TModel> GetAll()
        {
            return DbSet.Where(a => a.IsDeleted != true).ToList();
        }
    }

}