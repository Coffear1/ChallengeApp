﻿using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny Kierowników");
Console.WriteLine("========================================");
Console.WriteLine();

var employee = new EmployeeInFile("Krzysiek", "Stebel");

employee.AddGrade(34);
employee.AddGrade(54);





/*
while (true)
{
    Console.WriteLine("Podaj ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception mistake)
    {
        Console.WriteLine($"Exception catched: {mistake.Message}");
    }
}

Console.WriteLine();
var statistics = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AverageLetter: {statistics.AverageLetter}");
*/














