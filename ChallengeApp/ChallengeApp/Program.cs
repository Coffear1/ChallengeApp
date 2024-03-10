using ChallengeApp;

        Employee employee1 = new Employee("Adam", "Kowalski", 40);
        Employee employee2 = new Employee("Mateusz", "Gawlas", 32);
        Employee employee3 = new Employee("Wiktor", "Habdas", 38);

        List<Employee> employees = new List<Employee>()
        {
            employee1, employee2, employee3
        };

        employee1.AddScore(5);
        employee1.AddScore(6);
        employee1.AddScore(3);          //24
        employee1.AddScore(5);
        employee1.AddScore(5);

        employee2.AddScore(1);
        employee2.AddScore(4);
        employee2.AddScore(8);          //19
        employee2.AddScore(5);
        employee2.AddScore(1);

        employee3.AddScore(5);
        employee3.AddScore(6);
        employee3.AddScore(3);          //26
        employee3.AddScore(5);
        employee3.AddScore(7);

        Employee? employeeWithMaxResult = null;
        int maxResult = -1;

        foreach (var employee in employees)
        {
            if (employee.Result > maxResult)
            {
                maxResult = employee.Result;
                employeeWithMaxResult = employee;
            }
        }


        Console.WriteLine($"{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} lat {employeeWithMaxResult.Age} zdobył {employeeWithMaxResult.Result} punkty");
    












