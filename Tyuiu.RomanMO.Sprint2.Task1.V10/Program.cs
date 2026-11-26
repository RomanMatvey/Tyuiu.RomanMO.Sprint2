using Tyuiu.RomanMO.Sprint2.Task1.V10.Lib;

namespace Tyuiu.RomanMO.Sprint2.Task1.V10
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Роман Матвей Олегович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Использовать логические операции                                        *");
            Console.WriteLine("* , &,                                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* , &&, !, ^ по порядку.                                                  *");
            Console.WriteLine("* Получить True, False, False, False, True, False.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 455, b = 335, c = 14, d = 17;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");
            bool[] res = ds.GetLogicOperations(a, b, c, d);

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
