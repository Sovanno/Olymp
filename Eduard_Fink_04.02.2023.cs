using System;
using System.Data;

namespace ConsoleApp1
{
    class Stud
    {
        public string fio;
        public string day;
        public string month;
        public string year;
        public string group;
        public string[] dis;
        public string[] oze;

        public Stud(string fio, string year, string month, string day, string group, string[] dis, string[] oze)
        {
            this.fio = fio;
            this.day = day;
            this.month = month;
            this.year = year;
            this.group = group;
            this.dis = dis;
            this.oze = oze;
            
        }
    }
    public class ConsoleApp1
    {
        public static void Main()
        {
            List<Stud> list = new List<Stud>();
            string asd;
            int qwerty = 0, zxcv = 0;
            while (true)
            {
                Console.WriteLine(@"
1. Добавить студента
2. Сортировка по заданной группе
3. Сортировка по должникам
4. Сортировка по отличникам
5. Соритровка по возрасту(менее 20 лет)
6. Выход");

                string num = Convert.ToString(Console.ReadLine());

                if (num == "1")
                {
                    Console.WriteLine("Введите фио");
                    string fio = Console.ReadLine();
                    Console.WriteLine("Введите день");
                    string day = Console.ReadLine();
                    Console.WriteLine("Введите месяц");
                    string month = Console.ReadLine();
                    Console.WriteLine("Введите год");
                    string year = Console.ReadLine();
                    Console.WriteLine("Введите группа");
                    string group = Console.ReadLine();
                    Console.WriteLine("Колличество прдметов");
                    zxcv = Convert.ToInt32(Console.ReadLine());
                    string[] dis = new string[zxcv];
                    string[] oze = new string[zxcv];
                    for (int i = 0; i < zxcv; i++)
                    {
                        Console.WriteLine("Введите предмет");
                        dis[i] = Console.ReadLine();
                        Console.WriteLine("Введите оценка");
                        oze[i] = Console.ReadLine();
                    }
                    list.Add(new Stud(fio, year, month, day, group, dis, oze));
                }
                else if (num == "2")
                {
                    asd = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].group == asd)
                        {
                            qwerty++;
                            Console.WriteLine(list[i].fio);
                            Console.ReadKey();
                        }
                    }
                    if(qwerty == 0)
                    {
                        Console.WriteLine("Данных не найдено");
                        Console.ReadKey();
                    }
                    else
                    {
                        qwerty = 0;
                    }
                }
                else if (num == "3")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list[i].oze.Length; j++)
                        {
                            if (list[i].oze[j] == "0")
                            {
                                qwerty++;
                                Console.WriteLine(list[i].fio);
                                Console.ReadKey();
                            }
                        }
                    }
                    if (qwerty == 0)
                    {
                        Console.WriteLine("Данных не найдено");
                        Console.ReadKey();
                    }
                    else
                    {
                        qwerty = 0;
                    }
                }
                else if (num == "4")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        for (int j = 0; j < list[i].oze.Length; j++)
                        {
                            if (list[i].oze[j] == "5")
                            {
                                qwerty++;
                                Console.WriteLine(list[i].fio);
                                Console.ReadKey();
                            }
                        }
                    
                    }
                    if (qwerty == 0)
                    {
                        Console.WriteLine("Данных не найдено");
                        Console.ReadKey();
                    }
                    else
                    {
                        qwerty = 0;
                    }
                }
                else if(num == "5")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (Convert.ToInt32(list[i].year) >= 2003)
                        {
                                    qwerty++;
                                    Console.WriteLine(list[i].fio);
                                    Console.ReadKey();
                             
                        }
                    }
                    if (qwerty == 0)
                    {
                        Console.WriteLine("Данных не найдено");
                        Console.ReadKey();
                    }
                    else
                    {
                        qwerty = 0;
                    }
                }
                else if (num == "6")
                {
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}
