namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void TestAverageResult()
        {
            var employee = new Employee("Adam", "Kowalski");

            employee.AddGrade(58);
            employee.AddGrade(53);
            employee.AddGrade(-5);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(35, 33, statistic.Average);
        }

        [Test]
        public void TestMinResult()
        {
            var employee = new Employee("Adam", "Kowalski");

            employee.AddGrade(58);
            employee.AddGrade(53);
            employee.AddGrade(-5);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(-5, statistic.Min);
        }

        [Test]
        public void TestMaxResult()
        {
            var employee = new Employee("Adam", "Kowalski");

            employee.AddGrade(58);
            employee.AddGrade(53);
            employee.AddGrade(-5);

            var statistic = employee.GetStatistics();

            Assert.AreEqual(58, statistic.Max);



        }

    }
}
