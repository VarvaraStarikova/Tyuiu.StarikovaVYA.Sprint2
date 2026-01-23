using Tyuiu.StarikovaVYA.Sprint2.Task2.V30.Lib;
namespace Tyuiu.StarikovaVYA.Sprint2.Task2.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнила: Старикова В. Я. | СМАРТб-25-1";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #2                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #2                                                                     *");
            Console.WriteLine("* Вариант #30                                                                    *");
            Console.WriteLine("* Выполнила: Старикова Варвара Яковлевна | СМАРТб-25-1                           *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и       *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области.      *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            for (int i = 0; i < 15; i++)
            {
                for (int j = 1; j < 15; j++)
                {
                    if (ds.CheckDotInShadedArea(i, j))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("* Введите X:                                                                     *");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                                     *");
            y = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.CheckDotInShadedArea(x, y));

            Console.ReadLine();
        }
    }
}