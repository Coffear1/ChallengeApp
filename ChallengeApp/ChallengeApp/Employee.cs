
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee()
        {  
        }
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
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))                 // TryParse - sprawdza czy sparsowany parametr na pewno się zgadza 
            {                                                           // np. czy string jest "5" a nie "Adam"
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultLetter))
            {
                this.AddGrade(resultLetter);
            }
            else
            {
                throw new Exception("String is not float");
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

        public Statistics GetStatistics()
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

            switch (statistics.Average) 
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }                   
    }
}


