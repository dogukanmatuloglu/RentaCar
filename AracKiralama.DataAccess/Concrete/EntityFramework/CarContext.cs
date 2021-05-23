using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AracKiralama.Entities.Concrete;

namespace AracKiralama.DataAccess.Concrete.EntityFramework
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
