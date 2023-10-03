using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TarasovVD.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.TarasovVD.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт#0 | Выполнил: Тарасов.В.Д | ПКТб-23-2";
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* Спринт #0 *");
            Console.WriteLine("* Тема:Создание итогового решения по спринту *");
            Console.WriteLine("* Задание #8 *");
            Console.WriteLine("* Вариант #0 *");
            Console.WriteLine("* Выполнил: Тарасов.В.Д | ПКТб-23-2* ");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine("* Написать консольную программу C#,которая запрашивает данные,выполняет данное выражение и   *");
            Console.WriteLine("* выводит на экран результат *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ *");
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("Введите значение переменной x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение переменной z:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("*********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine("*********************************************************************************************");

            Console.WriteLine("(x + y + z) * 5 = " + DataService.Calc(x, y, z));
            Console.ReadKey();

        }
    }
}
