using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Class1
    {
        delegate void Delegate();
        public static double x;
        public static double y;
        class MyEvent
        {
            Delegate[] evnt = new Delegate[4];
            public event Delegate SomeEvent
            {
                add
                {
                    int i;
                    for (i = 0; i < 4; i++)
                        if (evnt[i] == null)
                        {
                            evnt[i] = value;
                            break;
                        }
                    if (i == 3) Console.WriteLine("Список событий заполнен.");
                }
                remove
                {
                    int i;
                    for (i = 0; i < 4; i++)
                        if (evnt[i] == value)
                        {
                            evnt[i] = null;
                            break;
                        }
                    if (i == 3) Console.WriteLine("Обработчик событий не найден.");
                }
            }
            public void OnSomeEvent()
            {
                for (int i = 0; i < 4; i++)
                    if (evnt[i] != null) evnt[i]();
            }

        }
        class Summ
        {
            public void Summer()
            {
                Console.WriteLine(x + y);
            }
        }
        class Minus
        {
            public void Minuser()
            {
                Console.WriteLine(x - y);
            }
        }
        class Multi
        {
            public void Multier()
            {
                Console.WriteLine(x * y);
            }
        }
        class Division
        {
            public void Divisioner()
            {
                if (y != 0)
                {
                    Console.WriteLine(x / y);
                }
                else
                {
                    Console.WriteLine("На ноль не делим");
                }
            }
        }

        static void Main()
        {
            MyEvent myEvent = new MyEvent();
            Summ summ = new Summ();
            Minus minus = new Minus();
            Multi multi = new Multi();
            Division division = new Division();

            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            myEvent.SomeEvent += summ.Summer;
            myEvent.SomeEvent += minus.Minuser;
            myEvent.SomeEvent += multi.Multier;
            myEvent.SomeEvent += division.Divisioner;

            myEvent.OnSomeEvent();
        }
    }
}
