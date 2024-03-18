using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny Pracowników");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new Employee();


while(true)
{
    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch(Exception mistake) 
    {
        Console.WriteLine($"Exception catched: {mistake.Message}");
    }
}

Console.WriteLine();
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");          
Console.WriteLine($"Min: {statistics.Min}");                        
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");















