using MF.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TContext, TEntity> : IEntityRepository<TEntity>
        where TEntity : class,IEntity, new() // new edilmemiş class ları kabul etme 
        where TContext : DbContext, new() //biz burada new işlemi yapacağız
    {
        public void Add(TEntity entity)
        {
            //Disposible bloğu -- blok bittikten sonra bağlantıyı dispose ediyor (cnn.Dispose();) 
            using (TContext context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public TEntity Get(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(filter).FirstOrDefault();
            }
        }

        public ICollection<TEntity> GetAll(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //return context.Set<TEntity>().Where(filter);
                return filter == null ?
                    context.Set<TEntity>().ToList() :
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }
    }
}
