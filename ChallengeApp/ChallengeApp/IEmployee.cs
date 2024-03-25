namespace ChallengeApp
{
    // inteface określa co ma być zaimplementowane, zawiera tylko definicje a nie logike
    // natomiast klasa określa jak to ma być zaimplementowane i zawiera logike
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        public void AddGrade(float grade);
        public void AddGrade(string grade);
        public void AddGrade(int grade);
        public void AddGrade(double grade);
        public void AddGrade(char grade);

        Statistics GetStatistics();
    }
}
