using Tyuiu.RomanMO.Sprint2.Task3.V28.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void ExampleTest1()
        {
            double x = 2;
            double res = ds.Calculate(x);
            double Wait_res = 1.881;
            Assert.AreEqual(Wait_res, res);
        }

        [TestMethod]
        public void ExampleTest2()
        {
            double x = 0;
            double res = ds.Calculate(x);
            double Wait_res = -5;
            Assert.AreEqual(Wait_res, res);
        }

        [TestMethod]
        public void ExampleTest3()
        {
            double x = -2;
            double res = ds.Calculate(x);
            double Wait_res = 0.007;
            Assert.AreEqual(Wait_res, res);
        }

        [TestMethod]
        public void ExampleTest4()
        {
            double x = -33;
            double res = ds.Calculate(x);
            double Wait_res = -362.788;
            Assert.AreEqual(Wait_res, res);
        }
    }
}
