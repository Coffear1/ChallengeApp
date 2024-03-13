using ChallengeApp;

var employee = new Employee("Krzysiek", "Stebel");
employee.AddGrade(53);
employee.AddGrade(58);
employee.AddGrade(-5);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");          // N2 określa ilośc cyfr po przecinku 
Console.WriteLine($"Min: {statistics.Min}");                        
Console.WriteLine($"Max: {statistics.Max}");














