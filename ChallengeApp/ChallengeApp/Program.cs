using ChallengeApp;

var employee = new Employee("Krzysiek", "Stebel");
employee.AddGrade(4);
employee.AddGrade(5);
employee.AddGrade(6);


var statistics1 = employee.GetStatisticsWith();
Console.WriteLine($"Average: {statistics1.Average:N2}");          // N2 określa ilośc cyfr po przecinku 
Console.WriteLine($"Min: {statistics1.Min}");                        
Console.WriteLine($"Max: {statistics1.Max}");















