using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOpsHandsOn03
{
    public class CarCollectionService
    {
        private CarCollection carCollection;
        public CarCollectionService()
        {
            carCollection = new CarCollection();
        }

        public void AddRandomCar(int amount)
        {
            var random = new Random();
            var carBrands = new List<string> { "Toyota", "Honda", "Ford", "Chevrolet", "BMW", "Mercedes" };

            for (int i = 0; i < amount; i++)
            {
                string randomCar = carBrands[random.Next(carBrands.Count)];
                carCollection.AddCar(randomCar);
            }
        }

        public List<string> GetCars()
        {
            return carCollection.GetCars();
        }
    }
}
