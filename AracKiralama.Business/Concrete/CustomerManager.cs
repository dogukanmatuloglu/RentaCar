using AracKiralama.DataAccess.Abstract;
using AracKiralama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Business.Concrete
{
    public class CustomerManager
    {
        ICustomerDal _customerDal;
        public CustomerManager( ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public List<Customer> GetAll()
        {

            return _customerDal.GetCars();
        }
        public void Add(Customer customer)
        {
            _customerDal.Add(customer);
        }
        public void Delete(Customer  customer)
        {
            _customerDal.Delete(customer);
        }
        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }
    }
}
