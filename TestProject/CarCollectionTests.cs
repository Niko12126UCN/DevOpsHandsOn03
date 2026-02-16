namespace TestProject
{
    public class CarCollectionTests
    {
        [Fact]
        public void AddCar_ShouldAddCarToCollection()
        {
            // Arrange
            var carCollection = new DevOpsHandsOn03.CarCollection();
            string car = "Toyota";
            // Act
            carCollection.AddCar(car);
            var cars = carCollection.GetCars();
            // Assert
            Assert.Contains(car, cars);
        }

        [Fact]
        public void RemoveCar_ShouldRemoveCarFromCollection()
        {
            // Arrange
            var carCollection = new DevOpsHandsOn03.CarCollection();
            string car = "Honda";
            carCollection.AddCar(car);
            // Act
            carCollection.RemoveCar(car);
            var cars = carCollection.GetCars();
            // Assert
            Assert.DoesNotContain(car, cars);
        }
    }
}
