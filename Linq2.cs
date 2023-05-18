using System;
using System.Numerics;
using System.Linq;
using Microsoft.VisualBasic;

namespace ConsoleApp1
{
    class Class1
    {
        static int count = 0;

        static void Filter(List<int> list)
        {
            var answerplus = from i in list
                             where i > 0
                             select i;
            foreach (int i in answerplus)
            {
                Console.WriteLine(i);
            }

            var answerminus = from i in list
                              where i < 0
                              select i;
            foreach (int i in answerminus)
            {
                count += i;
            }
            Console.WriteLine(count);
            count = 0;

            var answerFive = from i in list
                             where i % 5 == 0
                             select i;
            foreach (int i in answerFive)
            {
                count++;
            }
            Console.WriteLine(count);
        }
        static void Main()
        {
            List<int> list = new List<int>() { 1, 2, 3, -1, -2, -3, 5, -10};
            Filter(list);
            List<int> list2 = new List<int>();

            var proobraz = from i in list
                              where list.IndexOf(i) % 2 != 0
                              select i;
            foreach (int i in proobraz)
            {
                list2.Add(i);
            }
            Filter(list2);
        }
    }
}
