using Tyuiu.RomanMO.Sprint2.Task5.V7.Lib;

namespace Tyuiu.RomanMO.Sprint2.Task5.V7
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Роман Матвей Олегович | ПКТб-26-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Определить название месяца через n полных месяцев и 2 дня               *");
            Console.WriteLine("* после начала 1990 года. Использовать оператор switch.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startYear = 1990;
            Console.WriteLine("Введите количество полных месяцев:");
            int n = Convert.ToInt32(Console.ReadLine());
            string res = ds.FindMonthName(startYear, n);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Название месяца: {res}");

        }
    }
}
