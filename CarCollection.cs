using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsHandsOn03
{
    public class CarCollection
    {
        private List<string> cars;
        public CarCollection()
        {
            cars = new List<string>();
        }
        public void AddCar(string car)
        {
            if (!string.IsNullOrEmpty(car))
            {
                cars.Add(car);
            }
        }
        public void RemoveCar(string car)
        {
            if (cars.Contains(car))
            {
                cars.Remove(car);
            }
        }
        public List<string> GetCars()
        {
            return new List<string>(cars);
        }
    }
}
