using CarsApp;


namespace CarsApp.Tests
{
    public class CarsTests
    {
      
        [Test]
        public void DisplayAverage()
        {
            var cars = new CarsInMemory("Opel", "Corsa", "Hatchback", "2000");

            cars.AddGrade(30);
            cars.AddGrade(29);
            cars.AddGrade(50);

            var result = cars.GetStatistics();

            Assert.That(result.Average, Is.EqualTo(33));

        }


        

    }
}