using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Class1
    {
        public interface IMath
        {
            abstract double Summ(double x, double y);
            abstract double Diff(double x, double y);
            abstract double Muit(double x, double y);
            abstract double Del(double x, double y);
        }
        public class Calculate : IMath
        {
            public delegate double Delegate (double x, double y);
            public Delegate Summer;
            public Delegate Differ;
            public Delegate Muiter;
            public Delegate Deler;
            public Calculate()
            {
                Summer = Summ;
                Differ = Diff;
                Muiter = Muit;
                Deler = Del;
            }
            public double Summ(double x, double y)
            {
                return x + y;
            }
            public double Diff(double x, double y)
            {
                return x - y;
            }
            public double Muit(double x, double y)
            {
                return x * y;
            }
            public double Del(double x, double y)
            {
                return x / y;
            }

        }
        
        static void Main()
        {
            double x, y;
            Calculate calc = new Calculate();
            while (true)
            {

            Console.WriteLine(@"
Выбор действия:
1) Сумма 
2) Разница
3) Умножеине
4) Деление
5) Выход
");
            string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Summer(x, y));
                        Console.ReadKey();
                        break;
                    case "2":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Differ(x, y));
                        Console.ReadKey();
                        break;
                    case "3":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(calc.Muiter(x, y));
                        Console.ReadKey();
                        break;
                    case "4":
                        x = Convert.ToDouble(Console.ReadLine());
                        y = Convert.ToDouble(Console.ReadLine());
                        if (y != 0)
                        {
                            Console.WriteLine(calc.Deler(x, y));
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Environment.Exit(0);
                        break; 
                }
                Console.Clear();
            }
        }
    }
}
