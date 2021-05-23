using AracKiralama.DataAccess.Abstract;
using AracKiralama.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntitiyRepository<TEntity> where TEntity:class,IEntity,new() where TContext:DbContext ,new()
    { //efentityrepositorybase: diyelimki 100 lerce veri tabanı nesnemiz için ekleme silme güncelleme işleri yapıyoruz bunun için ayrı bir efcardal yazmak yerine her nesneye uyumlu olacak bir repository yaptık
        public void Add(TEntity car)
        {
           using(TContext context=new TContext())
            {
                var AddedEntitiy = context.Entry(car);
                AddedEntitiy.State = EntityState.Added;
                context.SaveChanges();
            }
        }

    

       

        public void Delete(TEntity car)
        {
            using (TContext context = new TContext())
            {
                var DeletedEntitiy = context.Entry(car);
                DeletedEntitiy.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

       

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetCars(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter==null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }
            
   

        public void Update(TEntity car)
        {
            using (TContext context = new TContext())
            {
                var UpdatededEntitiy = context.Entry(car);
                UpdatededEntitiy.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
