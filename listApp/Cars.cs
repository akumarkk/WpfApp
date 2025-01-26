using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    public class Cars
    {
        public static List<Car> GetCars()
        {
            return new List<Car>() { 
                new Car() {Owner= "Yash", Type= CarType.Sedan, CarBrand=CarBrand.PuneethBrand },
                new Car() {Owner= "Punith", Type= CarType.Sedan, CarBrand=CarBrand.RolceRoyes },
            };
        }
    }
}
