using Tyuiu.RomanMO.Sprint2.Task0.V19.Lib;

namespace Tyuiu.RomanMO.Sprint2.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Роман М. О. | ПКТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Роман Матвей Олегович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Получить массив сравнений в порядке ==, !=, <, >, <=, >=.               *");
            Console.WriteLine("* При x = 105 и y = 177 все шесть значений равны True.                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 105;
            int y = 177;
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            bool[] res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
}
