using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Timers;
using System.Linq;

namespace ConsoleApp4
{
    class tests
    {
        static void Main()
        {
            int[] ints = { 1, -10, 2, 3, -4,  4, 5, 6, -2};
            int count = 0;

            var answer1 = from p in ints
                          where p < 0
                          select p;
            foreach(int i in answer1)
            {
                count++;
            }
            Console.WriteLine(count);
            count = 0;

            var answer2 = from p in ints
                          where p > 0
                          select p;
            foreach (int i in answer2)
            {
                count += i;
            }
            Console.WriteLine(count);
            count = 1;

            var answer3 = from p in ints
                          where p % 2 == 0
                          select p;
            foreach (int i in answer2)
            {
                count *= i;
            }
            Console.WriteLine(count);
        }
    }
}
