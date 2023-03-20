using System;

public class ConsoleApp4
{
    public static void Main()
    {
        double otvet , asd, Min_Rast1, Min_Rast2, Min_Rast3, Min_Rast4, min_rast;
        double[] cubic = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] pavuk = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        double[] muxa = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        if ((cubic[0] == pavuk[0] && cubic[0] == muxa[0]) || (0 == pavuk[0] && 0 == muxa[0])) 
        {
            otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2));
            Console.WriteLine(Math.Round(otvet, 3));
        }
        else if ((cubic[1] == pavuk[1] && cubic[1] == muxa[1]) || (0 == pavuk[1] && 0 == muxa[1]))
        {
            otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2));
            Console.WriteLine(Math.Round(otvet, 3));
        }
        else if ((cubic[2] == pavuk[2] && cubic[2] == muxa[2]) || (0 == pavuk[2] && 0 == muxa[2]))
        {
            otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2));
            Console.WriteLine(Math.Round(otvet, 3));
        }
        else if ((cubic[0] == pavuk[0] && 0 == muxa[0]) || (cubic[0] == muxa[0] && 0 == pavuk[0]))
        {
            Min_Rast1 = pavuk[1] + muxa[1];
            Min_Rast2 = (cubic[1] - pavuk[1]) + (cubic[1] - muxa[1]);
            Min_Rast3 = pavuk[2] + muxa[2];
            Min_Rast4 = (cubic[2] - pavuk[2]) + (cubic[2] - muxa[2]);
            if (Min_Rast1 <= Min_Rast2 && Min_Rast1 <= Min_Rast3 && Min_Rast1 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2) + Math.Pow(Math.Abs(pavuk[1] + muxa[1] + cubic[0]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast2 <= Min_Rast1 && Min_Rast2 <= Min_Rast3 && Min_Rast2 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2) + Math.Pow(Math.Abs(cubic[1] - pavuk[1] + cubic[1] - muxa[1] + cubic[0]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast3 <= Min_Rast1 && Min_Rast3 <= Min_Rast2 && Min_Rast3 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(pavuk[2] + muxa[2] + cubic[0]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast4 <= Min_Rast1 && Min_Rast4 <= Min_Rast3 && Min_Rast4 <= Min_Rast2)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(cubic[2] - pavuk[2] + cubic[2] - muxa[2] + cubic[0]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if ((cubic[1] == pavuk[1] && 0 == muxa[1]) || (cubic[1] == muxa[1] && 0 == pavuk[1]))
        {
            Min_Rast1 = pavuk[0] + muxa[0];
            Min_Rast2 = (cubic[0] - pavuk[0]) + (cubic[0] - muxa[0]);
            Min_Rast3 = pavuk[2] + muxa[2];
            Min_Rast4 = (cubic[2] - pavuk[2]) + (cubic[2] - muxa[2]);
            if (Min_Rast1 <= Min_Rast2 && Min_Rast1 <= Min_Rast3 && Min_Rast1 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2) + Math.Pow(Math.Abs(pavuk[0] + muxa[0] + cubic[1]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast2 <= Min_Rast1 && Min_Rast2 <= Min_Rast3 && Min_Rast2 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2) + Math.Pow(Math.Abs(cubic[0] - pavuk[0] + cubic[0] - muxa[0] + cubic[1]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast3 <= Min_Rast1 && Min_Rast3 <= Min_Rast2 && Min_Rast3 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[2] + muxa[2] + cubic[1]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast4 <= Min_Rast1 && Min_Rast4 <= Min_Rast3 && Min_Rast4 <= Min_Rast2)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(cubic[2] - pavuk[2] + cubic[2] - muxa[2] + cubic[1]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if ((cubic[2] == pavuk[2] && 0 == muxa[2]) || (cubic[2] == muxa[2] && 0 == pavuk[2]))
        {
            Min_Rast1 = pavuk[0] + muxa[0];
            Min_Rast2 = (cubic[0] - pavuk[0]) + (cubic[0] - muxa[0]);
            Min_Rast3 = pavuk[1] + muxa[1];
            Min_Rast4 = (cubic[1] - pavuk[1]) + (cubic[1] - muxa[1]);
            if (Min_Rast1 <= Min_Rast2 && Min_Rast1 <= Min_Rast3 && Min_Rast1 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(pavuk[0] + muxa[0] + cubic[2]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast2 <= Min_Rast1 && Min_Rast2 <= Min_Rast3 && Min_Rast2 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(cubic[0] - pavuk[0] + cubic[0] - muxa[0] + cubic[2]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast3 <= Min_Rast1 && Min_Rast3 <= Min_Rast2 && Min_Rast3 <= Min_Rast4)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[1] + muxa[1] + cubic[2]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else if (Min_Rast4 <= Min_Rast1 && Min_Rast4 <= Min_Rast3 && Min_Rast4 <= Min_Rast2)
            {
                otvet = Math.Sqrt(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(cubic[1] - pavuk[1] + cubic[1] - muxa[1] + cubic[2]), 2));
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if (pavuk[0] == 0)
        {
            if ((muxa[1] == 0) || (muxa[1] == cubic[1]))
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[1] - muxa[1]) + muxa[0], 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]) + muxa[0], 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if (pavuk[0] == cubic[0])
        {
            if ((muxa[1] == 0) || (muxa[1] == cubic[1]))
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[1] - muxa[1]) + cubic[0] - muxa[0], 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]) + cubic[0] - muxa[0], 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if (pavuk[1] == 0)
        {
            if ((muxa[0] == 0) || (muxa[0] == cubic[0]))
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]) + muxa[1], 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]) + muxa[1], 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if (pavuk[1] == cubic[1])
        {
            if ((muxa[0] == 0) || (muxa[0] == cubic[0]))
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]) + cubic[1] - muxa[1], 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]), 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[2] - muxa[2]) + cubic[1] - muxa[1], 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }

        }
        else if (pavuk[2] == 0)
        {
            if ((muxa[0] == 0) || (muxa[0] == cubic[0]))
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]) + muxa[2], 2) + Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[1] - muxa[1]) + muxa[2], 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
        }
        else if (pavuk[2] == cubic[2])
        {
            if ((muxa[0] == 0) || (muxa[0] == cubic[0]))
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]) + cubic[2] - muxa[2], 2) + Math.Pow(Math.Abs(pavuk[1] - muxa[1]), 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }
            else
            {
                otvet = Math.Pow(Math.Pow(Math.Abs(pavuk[0] - muxa[0]), 2) + Math.Pow(Math.Abs(pavuk[1] - muxa[1]) + cubic[2] - muxa[2], 2), 0.5);
                Console.WriteLine(Math.Round(otvet, 3));
            }

        }
    }
}
