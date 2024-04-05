namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {

        }


        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)                              // WALIDACJA - weryfikacja czy dane są poprawne.
            {                                                           // w tym wypadku musimy dopilnować aby można było dodawać oceny 
                this.grades.Add(grade);                                  // tylko z zakresu 0-100

                if (GradeAdded != null)                                    // Miejsce gdzie event został odpalony 
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public override void AddGrade(string grade)
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
            var statistics = new Statistics();

            foreach( var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }
           
            return statistics;
        }
    }
}
