using CarsApp;


namespace CarsApp.Tests
{
    public class CarsTests
    {
      
        [Test]
        public void GiveMeAverage()
        {
            var cars = new CarsInMemory("Opel", "Corsa", "Hatchback", "2000");

            cars.AddGrade(30);
            cars.AddGrade(29);
            cars.AddGrade(40);

            var result = cars.GetStatistics();

            Assert.That(result.Average, Is.EqualTo(33));

        }

        [Test]
        public void GiveMeMin()
        {
            var cars = new CarsInMemory("Opel", "Corsa", "Hatchback", "2000");

            cars.AddGrade(35);
            cars.AddGrade(79);
            cars.AddGrade(60);

            var result = cars.GetStatistics();

            Assert.That(result.Min, Is.EqualTo(35));

        }


    }
}