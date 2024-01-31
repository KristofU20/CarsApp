using CarsApp;


namespace CarsApp.Tests
{
    public class CarTests
    {
      
        [Test]
        public void CheckAverage()
        {
            var car = new CarInMemory("Opel", "Corsa", "Hatchback", "2000");

            car.AddGrade(30);
            car.AddGrade(29);
            car.AddGrade(40);

            var result = car.GetStatistics();

            Assert.That(result.Average, Is.EqualTo(33));

        }

        [Test]
        public void CheckMin()
        {
            var car = new CarInMemory("Opel", "Corsa", "Hatchback", "2000");

            car.AddGrade(35);
            car.AddGrade(79);
            car.AddGrade(60);

            var result = car.GetStatistics();

            Assert.That(result.Min, Is.EqualTo(35));

        }


    }
}