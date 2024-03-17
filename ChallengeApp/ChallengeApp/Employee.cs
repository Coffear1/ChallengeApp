
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)                              // WALIDACJA - weryfikacja czy dane są poprawne.
            {                                                           // w tym wypadku musimy dopilnować aby można było dodawać oceny 
                this.grades.Add(grade);                                 // tylko z zakresu 0-100
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))                 // TryParse - sprawdza czy sparsowany parametr na pewno się zgadza 
            {                                                           // np. czy string jest "5" a nie "Adam"
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(int grade)
        {
            float floatValue = grade;
            this.AddGrade(floatValue);
        }

        public void AddGrade(uint grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public void AddGrade(long grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }
        public void AddGrade(double grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public Statistics GetStatisticsWith()
        {
            var statistics = new Statistics();

            // implementacja GetStatistics
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }                   
    }
}


