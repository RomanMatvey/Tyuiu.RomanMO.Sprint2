using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.RomanMO.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = {
                (a + d > b) | (c == d),
                (a < b) & (c <= d),
                (a <= b) || (c >= d),
                (c > d) && (a != b),
                !(c == d),
                (a > b) ^ (c != d)
            };
            return res;
        }
    }
}
