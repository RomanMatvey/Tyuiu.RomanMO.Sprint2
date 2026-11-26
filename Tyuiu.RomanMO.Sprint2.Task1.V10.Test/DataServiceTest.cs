using Tyuiu.RomanMO.Sprint2.Task1.V10.Lib;
namespace Tyuiu.RomanMO.Sprint2.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void CheckOperandOperation()
        {
            bool[] res_wait = { true, false, false, false, true, false };
            bool[] res = ds.GetLogicOperations(455, 335, 14, 17);
            CollectionAssert.AreEqual(res_wait, res);
        }
    }
}
