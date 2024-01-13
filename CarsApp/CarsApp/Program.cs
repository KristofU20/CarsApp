

using CarsApp;

Console.WriteLine("Witaj w aplikacji CarsApp służącej do oceny aut");
Console.WriteLine("===========================================");
Console.WriteLine();

var cars = new CarsInFile("Opel", "Corsa", "Hatchback", "2000");
cars.GradeAdded += CarsGradeAdded;

void CarsGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


while (true)
{
    Console.WriteLine("Podaj kolejną  ocenę auta: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        cars.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = cars.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min:  {statistics.Min}");
Console.WriteLine($"Max:  {statistics.Max}");
Console.WriteLine($"AvarageLetter: {statistics.AverageLetter}");