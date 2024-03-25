﻿namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)                        
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }         
        }

        public override void AddGrade(string grade)
        {

            if (float.TryParse(grade, out float result))                 
            {                                                           
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

        public override void AddGrade(int grade)
        {
            float floatValue = grade;
            this.AddGrade(floatValue);
        }

        public override void AddGrade(double grade)
        {
            float floatValue = (float)grade;
            this.AddGrade(floatValue);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Min = float.MaxValue;
            result.Max = float.MinValue;
            result.Average = 0;
            var counter = 0;

            if(File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        result.Min = Math.Min(result.Min, number);  
                        result.Max = Math.Max(result.Max, number);
                        result.Average = result.Average + number;
                        counter ++;
                    }
                }
            }
            result.Average = result.Average / counter;

            switch (result.Average)
            {
                case var average when average >= 80:
                    result.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    result.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    result.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    result.AverageLetter = 'D';
                    break;
                default:
                    result.AverageLetter = 'E';
                    break;
            }
            return result;
        }
    }
}
