using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Class1
    {
        delegate void Delegate (int n);
        class MyEvent
        {
            public event Delegate SomeEvent;
            public void OnSomeEvent(int n)
            {
                if (SomeEvent != null)
                    SomeEvent(n);
            }
        }

        static void Main()
        {
            double x, y;
            MyEvent myEvent = new MyEvent();

            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());

            myEvent.SomeEvent += (n) => Console.WriteLine(x + y);
            myEvent.SomeEvent += (n) => Console.WriteLine(x - y);
            myEvent.SomeEvent += (n) => Console.WriteLine(x * y);
            if (y != 0) 
            {
                myEvent.SomeEvent += (n) => Console.WriteLine(x / y);
            }
            else
            {
                myEvent.SomeEvent += (n) => Console.WriteLine("На ноль не делим");
            }

            myEvent.OnSomeEvent(1);
        }
    }
}
