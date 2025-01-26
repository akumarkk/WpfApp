
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    public class Car
    {
        public Car() { }
        public Car(string own, CarType type) {
            Owner = own;
            Type= type;
        }
        public string Owner { get; set; }
        public CarBrand CarBrand { get; set; }
        public CarType Type { get; set; }

    }
}
