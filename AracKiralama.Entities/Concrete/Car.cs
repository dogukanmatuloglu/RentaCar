using AracKiralama.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public int Yıl { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Kilometre { get; set; }
        public string Durum { get; set; }
        public DateTime? Saat { get; set; } /*https://stackoverflow.com/questions/20800273/the-xxx-property-on-xxx-could-not-be-set-to-a-null-value-you-must-set-thi*/
    }
}
