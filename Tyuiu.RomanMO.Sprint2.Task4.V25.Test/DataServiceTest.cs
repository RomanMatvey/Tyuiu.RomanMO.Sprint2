using Tyuiu.RomanMO.Sprint2.Task4.V25.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckExample1()
        {
            double res = ds.Calculate(2, 2);
            Assert.AreEqual(2.25, res);
        }

        [TestMethod]
        public void CheckExample2()
        {
            double res = ds.Calculate(0, -160);
            Assert.AreEqual(-159.0, res);
        }
    }
}
