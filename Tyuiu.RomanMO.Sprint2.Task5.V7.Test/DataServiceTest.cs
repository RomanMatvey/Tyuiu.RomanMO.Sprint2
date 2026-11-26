using Tyuiu.RomanMO.Sprint2.Task5.V7.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckJanuary()
        {
            string res = ds.FindMonthName(1990, 0);
            Assert.AreEqual("январь", res);
        }

        [TestMethod]
        public void CheckFebruary()
        {
            string res = ds.FindMonthName(1990, 1);
            Assert.AreEqual("февраль", res);
        }

        [TestMethod]
        public void CheckNextYear()
        {
            string res = ds.FindMonthName(1990, 12);
            Assert.AreEqual("январь", res);
        }

        [TestMethod]
        public void CheckDecember()
        {
            string res = ds.FindMonthName(1990, 23);
            Assert.AreEqual("декабрь", res);
        }
    }
}
