using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.DataAccess.Abstract;
using AracKiralama.Entities.Concrete;



namespace AracKiralama.DataAccess.Concrete.EntityFramework
{
    public class EfCarsDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal //Eğer Farklı veri tabanlarını da desteklemek istiyorsak tüm Ormler Icardal implemente edeceği için Icardal üzerinden geçişler yapabileceğiz
    {
 
   
        public void CarState(Car car)
        {
            using(CarContext carContext= new CarContext())
            {
                var entitiy=carContext.Cars.Where(c => c.Id == car.Id).FirstOrDefault();
                entitiy.Durum = "Mesgul";
                carContext.SaveChanges();
            }
        }
        public List<Car> KiradakiAraclariListele()
        {
            using(CarContext context=new CarContext())
            {
                // var entitiy = from car in context.Cars where car.Durum == "Meşgul" select car.Plaka;

               // return context.Cars.Where(c => c.Durum == "Meşgul").ToList();
               var entitiy =context.Cars.Where(c => c.Durum == "Mesgul").Select(arac=>arac.Plaka).ToList();
                var entity2 = entitiy.Select(plaka => new Car { Plaka = plaka }).ToList();
                return entity2;
            }
        }
        public void CarState2(Car car)
        {
            using (CarContext carContext = new CarContext())
            {
                var entitiy = carContext.Cars.Where(c => c.Id == car.Id).FirstOrDefault();
                entitiy.Durum = "Musait";
                carContext.SaveChanges();
            }
        }
        public void KiralandıgiSaatiYaz(Car car)
        {
            using(CarContext context=new CarContext())
            {
                var entitiy = context.Cars.Where(c => c.Id == car.Id).FirstOrDefault();
                entitiy.Saat = car.Saat;
                context.SaveChanges();
            }
        }
        public List<Car> KiradakiAraclariListele2()
        {
            using (CarContext context = new CarContext())
            {
                // var entitiy = from car in context.Cars where car.Durum == "Meşgul" select car.Plaka;

                // return context.Cars.Where(c => c.Durum == "Meşgul").ToList();


                return context.Cars.Where(c => c.Durum == "Mesgul").ToList();
            }
        }
        public void SaatiSıfırla(Car car)
        {
            using(CarContext context=new CarContext())
            {
                var entitiy = context.Cars.Where(c => c.Id == car.Id).FirstOrDefault();
                entitiy.Saat = null;
                context.SaveChanges();
            }
        }
        public List<Car> GarajdakiAraclariListele()
        {
            using (CarContext context=new CarContext())
            {

                return context.Cars.Where(c => c.Durum == "Musait").ToList();
            }
        }

        
    }
}
