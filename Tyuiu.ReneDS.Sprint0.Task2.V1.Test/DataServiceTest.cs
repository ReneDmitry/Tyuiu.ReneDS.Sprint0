using Tyuiu.ReneDS.Sprint0.Task2.V1.Lib;

namespace Tyuiu.ReneDS.Sprint0.Task2.V1.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckGetMessageValid()
        {
            var name = "Дмитрий";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Дмитрий", res);
        }
    }
}