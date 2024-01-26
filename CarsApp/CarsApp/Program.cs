

using CarsApp;

Console.WriteLine("Witaj w aplikacji CarsApp służącej do oceny aut");
Console.WriteLine("===========================================");
Console.WriteLine();
Console.WriteLine("Jeśli chcesz dostać statystki, wprowadz'q'");
Console.WriteLine("Podaj ocene samochodu");

var cars = new CarsInMemory("Opel", "Corsa", "Hatchback", "2000");
cars.GradeAdded += CarsGradeAdded;

void CarsGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}


while (true)
{    
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