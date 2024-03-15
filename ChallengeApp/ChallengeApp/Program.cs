using ChallengeApp;

var employee = new Employee("Krzysiek", "Stebel");
employee.AddGrade(4);
employee.AddGrade(5);
employee.AddGrade(6);


var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("Oceny liczone metodą GetStatisticsWithForEach");
Console.WriteLine($"Average: {statistics1.Average:N2}");          // N2 określa ilośc cyfr po przecinku 
Console.WriteLine($"Min: {statistics1.Min}");                        
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine("__________________________________________________");
var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("Oceny liczone metodą GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics2.Average:N2}");          
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine("__________________________________________________");
var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("Oceny liczone metodą GetStatisticsWithDoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine("__________________________________________________");
var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine("Oceny liczone metodą GetStatisticsWithWhile");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");













