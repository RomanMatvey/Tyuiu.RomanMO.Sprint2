using Tyuiu.RomanMO.Sprint2.Task6.V3.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckMonday()
        {
            string res = ds.FindDayName(1);
            Assert.AreEqual("понедельник", res);
        }

        [TestMethod]
        public void CheckTuesday()
        {
            string res = ds.FindDayName(2);
            Assert.AreEqual("вторник", res);
        }

        [TestMethod]
        public void CheckThursday()
        {
            string res = ds.FindDayName(4);
            Assert.AreEqual("четверг", res);
        }

        [TestMethod]
        public void CheckSunday()
        {
            string res = ds.FindDayName(7);
            Assert.AreEqual("воскресенье", res);
        }
    }
}
