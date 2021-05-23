using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralama.Entities.Concrete;
using AracKiralama.DataAccess.Concrete.EntityFramework;
using System.Timers;
using AracKiralama.DataAccess.Abstract;

namespace AracKiralama.Business.Concrete
{
    
    public class CarManager
    {
        private ICarDal _CarsDal;

        public CarManager(ICarDal carsDal)//Dependency İnjection deseni 

        {
            _CarsDal = carsDal;
        }

       // EfCarsDal CarsDal = new EfCarsDal();  bu kod burada yanlışdır çünkü bağımlılık oluşturur solid prensiplerine terstir. Üstelik Arayüz katmanında manager sınıfı new lendiği zaman
       // bizden Icardal türünde bir şey isteyeceği için hem farklı ORM LER kullanabiliriz. çünkü Icardal diğer orm leride implemente ediyor olacak.
        public List<Car> GetAll()
        {

            return _CarsDal.GetCars();
        }
        public void Add(Car car)
        {
            _CarsDal.Add(car);
        }
        public void Delete(Car car)
        {
            _CarsDal.Delete(car);
        }
        public void Update(Car car)
        {
            _CarsDal.Update(car);
        }
        
        public void CarStateChange(Car car)
        {
            _CarsDal.CarState(car);
        }
        public void CarStateChange2(Car car)
        {
            _CarsDal.CarState2(car);
        }
        public List<Car> KiradakiAraçlarıListele()
        {
           return _CarsDal.KiradakiAraclariListele2();
        }
        public void AracSureBaslat(int sure)
        {
            
           
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
           
        }

        public void SureDoldugunda(Car car,System.Timers.ElapsedEventHandler elapsedEventHandler)
        {
            
        }
        public void KiralandigiSaatiYaz(Car car)
        {
            _CarsDal.KiralandıgiSaatiYaz(car);
        }
        public void SaatiSıfırlaManager(Car car)
        {
            _CarsDal.SaatiSıfırla(car);
        }
        public List<Car> GarajdakiAraclariListele()
        {
            return _CarsDal.GarajdakiAraclariListele();

        }
    }
}
