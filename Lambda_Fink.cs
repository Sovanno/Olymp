using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Class1
    {
        delegate void Delegate (double x, double y, double z);
        
        static void Main()
        {
            double x, y, z;
            Delegate summ = (double x, double y, double z) => Console.WriteLine(x + y + z);
            Delegate mult = (double x, double y, double z) => Console.WriteLine(x * y * z);
            Delegate max = (double x, double y, double z) => Console.WriteLine(Math.Max(Math.Max(x, y), z));
            Delegate min = (double x, double y, double z) => Console.WriteLine(Math.Min(Math.Min(x, y), z));
            Delegate mid = (double x, double y, double z) => Console.WriteLine((x + y + z)/3);
            while (true)
            {

            Console.WriteLine(@"
Выбор действия:
1) Максимум
2) Минимум
3) Сумма
4) Произведение
5) Среднее арифметическое
6) Выход
");
            string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        z = Convert.ToDouble(Console.ReadLine());
                        max(x, y, z);
                        Console.ReadKey();
                        break;
                    case "2":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        z = Convert.ToDouble(Console.ReadLine());
                        min(x, y, z);
                        Console.ReadKey();
                        break;
                    case "3":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        z = Convert.ToDouble(Console.ReadLine());
                        summ(x, y, z);
                        Console.ReadKey();
                        break;
                    case "4":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        z = Convert.ToDouble(Console.ReadLine());
                        mult(x, y, z);
                        break;
                    case "5":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        z = Convert.ToDouble(Console.ReadLine());
                        mid(x, y, z);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break; 
                }
                Console.Clear();
            }
        }
    }
}
