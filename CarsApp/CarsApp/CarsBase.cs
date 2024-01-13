

namespace CarsApp
{
    public abstract class CarsBase : ICars
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public CarsBase(string mark, string model, string bodytype, string yearofproduction)
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

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistics();
    }
}