using AracKiralama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DataAccess.Abstract
{
    public interface ICarDal : IEntitiyRepository<Car> //Icardal interfacini oluşturmamızın sebeni yarın öbür gün farklı bir orm kullandığımızzda  oda ıcardal ı implemente edecek ve biz 
        //ıcardal üzerinden geçişler yapabileceğiz.
    {
        void CarState(Car car);
        List<Car> KiradakiAraclariListele();
        void CarState2(Car car);
        void KiralandıgiSaatiYaz(Car car);
        List<Car> KiradakiAraclariListele2();
        void SaatiSıfırla(Car car);
        List<Car> GarajdakiAraclariListele();

    }
}
