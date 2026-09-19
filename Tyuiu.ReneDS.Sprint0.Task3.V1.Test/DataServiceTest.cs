using Tyuiu.ReneDS.Sprint0.Task3.V1.Lib;
namespace Tyuiu.ReneDS.Sprint0.Task3.V1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}