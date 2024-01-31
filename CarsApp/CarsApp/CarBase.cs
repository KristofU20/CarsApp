

namespace CarsApp
{
    public abstract class CarBase : ICar
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public CarBase(string mark, string model, string bodytype, string yearofproduction)
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
        
        public  void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");

            }
        }

        public void AddGrade(double grade)
        {
            float valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        public void AddGrade(int grade)
        {
            float valueinfloat = (float)grade;
            AddGrade(valueinfloat);
        }

        
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
        }

        public abstract Statistics GetStatistics();
    }
}