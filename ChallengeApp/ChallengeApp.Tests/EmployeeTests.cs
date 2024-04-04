namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestAverageResult()
        {
            var employee = new EmployeeInMemory("Adam", "Kowalski");

            employee.AddGrade(58);
            employee.AddGrade(53);
            employee.AddGrade(-5);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(35, 33, statistic.Average);
        }

        [Test]
        public void TestMinResult()
        {
            var employee = new EmployeeInMemory("Adam", "Kowalski");

            employee.AddGrade(52);
            employee.AddGrade(43);
            employee.AddGrade(20);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(20, statistic.Min); 
        }

        [Test]
        public void TestMaxResult()
        {
            var employee = new EmployeeInMemory("Adam", "Kowalski");

            employee.AddGrade(58);
            employee.AddGrade(53);
            employee.AddGrade(-5);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(58, statistic.Max);
        }

        [Test]
        public void TestAverageLetter()
        {
            var employee = new EmployeeInMemory("Adam", "Kowalski");

            employee.AddGrade(65);
            employee.AddGrade(100);
            employee.AddGrade(20);

            var statistic = employee.GetStatistics();

            Assert.AreEqual('B', statistic.AverageLetter);
        }

        [Test]
        public void TestAddGradeWitchChar()
        {
            var employee = new EmployeeInMemory("Adam", "Kowalski");

            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('D');

            var statistic = employee.GetStatistics();

            Assert.AreEqual(73, 33, statistic.Average);
        }
    }
}
