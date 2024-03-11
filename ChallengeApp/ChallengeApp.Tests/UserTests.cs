namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectThreeScores_ShouldCorrectResult()
        {
            // arrange - przygotowanie kodu 
            var user = new User("Krzysiek", "234234230");
            user.AddScore(5);
            user.AddScore(5);
            user.RemoveScore(5);
            

            //act - uruchamianie kodu 
            var result = user.Result;

            //assert - sprawdzamy czy zosta³y spe³nione odpowiednie warunki 
            Assert.AreEqual(5, result);
        }

    }
}