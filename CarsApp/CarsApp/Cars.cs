

namespace CarsApp
{
    public class Cars
    {
        public Cars (string mark, string model, string bodytype, string yearofproduction)
        {
            this.Mark = mark;
            this.Model = model;
            this.BodyType = bodytype;
            this.YearOfProduction = yearofproduction;
        }

        public string Mark { get; private set; }
        public string Model { get; private set; }

        public string BodyType { get; private set; }
        public string YearOfProduction { get; private set; }
    }
}

