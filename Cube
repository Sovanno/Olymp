using System;

namespace ConsoleApp1
{
    class ConsoleApp1
    {
        public static void Main()
        {
            int n, m, x, y, z, sec, inv, a;
            string[] temp = new string[2]; temp = Console.ReadLine().Split(); n = int.Parse(temp[0]); m = int.Parse(temp[1]);
            string[] tem1 = new string[3]; tem1 = Console.ReadLine().Split(); x = int.Parse(tem1[0]); y = int.Parse(tem1[1]); z = int.Parse(tem1[2]);
            for (int i = 0; i < n; i++)
            {
                string os = Convert.ToString(Console.ReadLine());
                if (os == "z")
                {
                    sec = Convert.ToInt32(Console.ReadLine());
                    if (sec == z)
                    {
                        inv = Convert.ToInt32(Console.ReadLine());
                        if (inv == 1)
                        {
                            a = x;
                            x = y;
                            y = n - a + 1;
                        }
                        else if (inv == -1)
                        {
                            for(int j = 0; j < 3; j++)
                            {
                                a = x;
                                x = y;
                                y = n - a + 1;
                            }
                        }
                    }
                }
                else if (os == "x")
                {
                    sec = Convert.ToInt32(Console.ReadLine());
                    if (sec == x)
                    {
                        inv = Convert.ToInt32(Console.ReadLine());
                        if (inv == 1)
                        {
                            a = y;
                            y = z;
                            z = n - a + 1;
                        }
                        else if (inv == -1)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                a = y;
                                y = z;
                                z = n - a + 1;
                            }
                        }
                    }
                }
                else if (os == "y")
                {
                    sec = Convert.ToInt32(Console.ReadLine());
                    if (sec == y)
                    {
                        inv = Convert.ToInt32(Console.ReadLine());
                        if (inv == 1)
                        {
                            a = x;
                            x = z;
                            z = n - a + 1;
                        }
                        else if (inv == -1)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                a = x;
                                x = z;
                                z = n - a + 1;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }

    }
}
