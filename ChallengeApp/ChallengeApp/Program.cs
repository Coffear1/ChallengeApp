using ChallengeApp;

var employee = new Employee("Krzysiek", "Stebel");
employee.AddGrade("Krzysiek");
employee.AddGrade("101");
employee.AddGrade(6);
employee.AddGrade(5);
employee.AddGrade(1);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");          // N2 określa ilośc cyfr po przecinku 
Console.WriteLine($"Min: {statistics.Min}");                        
Console.WriteLine($"Max: {statistics.Max}");














