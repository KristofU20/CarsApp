

using static CarsApp.CarBase;

namespace CarsApp
{
    public class CarInMemory : CarBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public CarInMemory(string mark, string model, string bodytype, string yearofproduction)
            : base(mark, model, bodytype, yearofproduction)
        {

        }

        public override void AddGrade(float grade)
        {
            int valueInInt = (int)grade;
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }

        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;

        }
    }

}
