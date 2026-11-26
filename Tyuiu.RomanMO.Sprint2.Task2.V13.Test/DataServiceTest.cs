using Tyuiu.RomanMO.Sprint2.Task2.V13.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckBlackSquare()
        {
            Assert.IsTrue(ds.CheckDotInShadedArea(9, 6));
        }
    }
}
