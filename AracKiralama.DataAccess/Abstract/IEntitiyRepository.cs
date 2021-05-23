using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Linq.Expressions;
using AracKiralama.Entities.Abstract;

namespace AracKiralama.DataAccess.Abstract
{
    public interface IEntitiyRepository<T> where T: class,IEntity,new() //düşünki onlarca veri tabanı nesnen var herbiri için farklı ekle sil işlemi yazmak yerine bir repository 
        //oluşturduk ve bu repositoryi uygulayacak nesne direk olarak metodları içerecek
    {
        List<T> GetCars(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T car);
        void Delete(T car);
        void Update(T car);
     
    }
}
