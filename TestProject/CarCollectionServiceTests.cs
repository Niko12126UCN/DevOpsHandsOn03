using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    public class CarCollectionServiceTests
    {
        [Fact]
        public void AddRandomCar_ShouldAddSpecifiedAmountOfCars()
        {
            // Arrange
            var carCollectionService = new DevOpsHandsOn03.CarCollectionService();
            int amount = 5;
            // Act
            carCollectionService.AddRandomCar(amount);
            var cars = carCollectionService.GetCars();
            // Assert
            Assert.Equal(amount, 3);
        }
    }
}
