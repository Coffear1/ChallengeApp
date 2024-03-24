
using ChallengeApp;
namespace ChallengeApp;

    public class Supervisor : IEmployee
{
    private List<float> grades = new List<float>();

    public Supervisor(string name, string surname, char sex)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public char Sex { get; private set; }
    
    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)                              
        {                                                          
            this.grades.Add(grade);                                 
        }
        else
        {
            throw new Exception("invalid grade value");
        }
    }

    public void AddGrade(string grade)
    {
       
        switch (grade) 
        {
            case "6":
                this.AddGrade(100);
                break;
            case "-6":
            case "6-":
                this .AddGrade(95);
                break;
            case "+5":
            case "5+":
                this.AddGrade(85);
                break;
            case "5":
                this.AddGrade(80);
                break;
            case "-5":
            case "5-":
                this.AddGrade(75);
                break;
            case "+4":
            case "4+":
                this.AddGrade(65);
                break;
            case "4":
                this.AddGrade(60);
                break;
            case "-4":
            case "4-":
                this.AddGrade(55);
                break;
            case "+3":
            case "3+":
                this.AddGrade(45);
                break;
            case "3":
                this.AddGrade(40);
                break;
            case "-3":
            case "3-":
                this.AddGrade(35);
                break;
            case "+2":
            case "2+":
                this.AddGrade(25);
                break;
            case "2":
                this.AddGrade(20);
                break;
            case "-2":
            case "2-":
                this.AddGrade(15);
                break;
            case "+1":
            case "1+":
                this.AddGrade(5);
                break;
            case "1":
                this.AddGrade(0);
                break;
            default:
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

    public void AddGrade(char grade)
    {
        throw new NotImplementedException();
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



    

   
                  
    




