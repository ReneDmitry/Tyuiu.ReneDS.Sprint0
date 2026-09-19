using Tyuiu.ReneDS.Sprint0.Task4.V1.Lib;
namespace Tyuiu.ReneDS.Sprint0.Task4.V1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [Test]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [Test]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [Test]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}