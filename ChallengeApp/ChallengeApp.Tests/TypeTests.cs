

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void TestOfIntNumbers()
        {
            // arrange 
            int number1 = 1;
            int number2 = 2;
            int number3 = 2;

            //assert 
            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(number2, number3);
        }

        [Test]
        public void TestOfFloatNumbers()
        {
            // arrange 
            float number1 = 1.35f;
            float number2 = 2.45f;
            float number3 = 2.45f;

            //assert 
            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(number2, number3);
        }

        [Test]
        public void TestOfDoubleNumbers()
        {
            // arrange 
            double number1 = 1.35342424f;
            double number2 = 2.45678f;
            double number3 = 2.45678f;

            //assert 
            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(number2, number3);
        }

        [Test]
        public void TestOfNumbersInString()
        {
            // arrange 
            string number1 = "1.35f";
            string number2 = "2.45f";
            string number3 = "2.45f";

            //assert 
            Assert.AreNotEqual(number1, number2);
            Assert.AreEqual(number2, number3);
        }

        [Test]
        public void TestOfString()
        {
            // arrange 
            string name1 = "Paweł";
            string name2 = "Radek";
            string name3 = "Radek";

            //assert 
            Assert.AreNotEqual(name1, name2);
            Assert.AreEqual(name2, name3);
        }

        [Test]
        public void TestOfTypesReference()
        {
            // arrange 
            var employee1 = new Employee("Adam", "Kowalski", 45);
            var employee2 = new Employee("Adam", "Kowalski", 45);

            //assert 
            Assert.AreNotEqual(employee1, employee2);
            Assert.AreEqual(employee1.Name, employee2.Name);
            Assert.AreEqual(employee1.Surname, employee2.Surname);
            Assert.AreEqual(employee1.Age, employee2.Age);
        }
    }
}
