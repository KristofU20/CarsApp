
namespace CarsApp
{
    public interface ICars
    {
        string Mark { get; }
        string Model { get; }
        string BodyType { get; }
        string YearOfProduction { get; }

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);


        Statistics GetStatistics();
    }
}
