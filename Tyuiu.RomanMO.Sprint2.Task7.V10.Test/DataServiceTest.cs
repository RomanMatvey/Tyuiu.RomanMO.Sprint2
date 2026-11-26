using Tyuiu.RomanMO.Sprint2.Task7.V10.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestBlackArea()
        {
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, -0.5));
        }
    }
}
