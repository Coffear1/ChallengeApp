namespace ChallengeApp
{
    public class User
    {
        private List<int> score = new List<int>();
        public User(string login, string password)   // Konstruktor
        {
            this.Login = login;
            this.Password = password;
        }

        public User(string login)   // Konstruktor
        {
            this.Login = login;
            
        }



        public string Login { get; private set; }           // Pola (propercje) - parametry opisujące obiekt
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }

        }


        public void AddScore(int score)            // Metoda na dodanie oceny 
        {
            this.score.Add(score);
        }

        public void RemoveScore(int score)         // Metoda na obniżenie oceny 
        { 
            this.score.Add(score * (-1));
        }
    }
}
