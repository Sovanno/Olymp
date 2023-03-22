using System;
using System.Data;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Stud
    {
        public string fio;
        public string group;
        public string[] dis;
        public string[] oze;

        public Stud(string fio, string group, string[] dis, string[] oze)
        {
            this.fio = fio;
            this.group = group;
            this.dis = dis;
            this.oze = oze;
            
        }
    }

    class Prepod
    {
        public string fio;
        public string[] groups;
        public string[] subg;

        public Prepod(string fio, string[] groups, string[] subg)
        {
            this.fio = fio;
            this.groups = groups;
            this.subg = subg;
        }
    }

    class Vspomog
    {
        public string fio;
        public string dolg;

        public Vspomog(string fio, string dolg)
        {
            this.fio = fio;
            this.dolg = dolg;
        }
    }

    class UPR
    {
        public string fio;
        public string dolg;
        public string[] ukaz;

        public UPR(string fio, string dolg, string[] ukaz)
        {
            this.fio = fio;
            this.dolg = dolg;
            this.ukaz = ukaz;
        }
    }
    public class ConsoleApp1
    {
        public static void Main()
        {
            List<Stud> list = new List<Stud>();
            List<Prepod> prepod = new List<Prepod>();
            List<UPR> upr = new List<UPR>();
            List<Vspomog> vspomog = new List<Vspomog>();
            string asd;
            int qwerty = 0, zxcv = 0;
            while (true)
            {
                Console.WriteLine(@"
1. Добавить человека
2. Указы
3. Перечень преподавателей с должниками 
4. Вывод студента с его долгами
5. Выход");

                string num = Convert.ToString(Console.ReadLine());

                if (num == "1")
                {
                    Console.WriteLine(@"
1. Добавить студента
2. Добавить преподавателя
3. Добавить управляющего
4. Добавить рабочего");
                    num = Convert.ToString(Console.ReadLine());
                    if (num == "1")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
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
                        list.Add(new Stud(fio, group, dis, oze));
                    }
                    else if (num == "2")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Колличество групп");
                        zxcv = Convert.ToInt32(Console.ReadLine());
                        string[] groups = new string[zxcv];
                        for (int i = 0; i < zxcv; i++)
                        {
                            Console.WriteLine("Введите группа");
                            groups[i] = Console.ReadLine();
                        }
                        Console.WriteLine("Колличество предметов");
                        zxcv = Convert.ToInt32(Console.ReadLine());
                        string[] subg = new string[zxcv];
                        for (int i = 0; i < zxcv; i++)
                        {
                            Console.WriteLine("Введите предмет");
                            subg[i] = Console.ReadLine();
                        }
                        prepod.Add(new Prepod(fio, groups, subg));
                    }
                    else if (num == "3")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите должность");
                        string dolg = Console.ReadLine();
                        Console.WriteLine("Колличество указов");
                        zxcv = Convert.ToInt32(Console.ReadLine());
                        string[] ukaz = new string[zxcv];
                        for (int i = 0; i < zxcv; i++)
                        {
                            Console.WriteLine("Введите указ");
                            ukaz[i] = Console.ReadLine();
                        }
                        upr.Add(new UPR(fio, dolg, ukaz));
                    }
                    else if (num == "4")
                    {
                        Console.WriteLine("Введите фио");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите должность");
                        string dolg = Console.ReadLine();
                        vspomog.Add(new Vspomog(fio, dolg));
                    }

                }
                else if (num == "2")
                {
                    Console.WriteLine(@"
1. Указы студентам
2. Указы преподавателям
3. Указы вспомогательным
4. Указы общие");
                    asd = Console.ReadLine();
                    if(asd == "1")
                    {
                        for(int i = 0; i < upr.Count; i++)
                        {
                            for(int j = 0; j < upr[i].ukaz.Length; j++)
                            {
                                if (upr[i].ukaz[j].ToString().Substring(0, 2) == "ST" || upr[i].ukaz[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].ukaz[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (asd == "2")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].ukaz.Length; j++)
                            {
                                if (upr[i].ukaz[j].ToString().Substring(0, 2) == "PR" || upr[i].ukaz[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].ukaz[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (asd == "3")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].ukaz.Length; j++)
                            {
                                if (upr[i].ukaz[j].ToString().Substring(0, 2) == "VS" || upr[i].ukaz[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].ukaz[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                    else if (asd == "4")
                    {
                        for (int i = 0; i < upr.Count; i++)
                        {
                            for (int j = 0; j < upr[i].ukaz.Length; j++)
                            {
                                if (upr[i].ukaz[j].ToString().Substring(0, 2) == "OB")
                                {
                                    Console.WriteLine(upr[i].ukaz[j] + "-" + upr[i].fio);
                                }
                            }
                        }
                        Console.ReadKey();
                    }
                }
                else if (num == "3")
                {
                    asd = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                            for (int j = 0; j < list[i].oze.Length; j++)
                            {
                                if (list[i].oze[j] == "0")
                                {
                                    qwerty++;
                                    for (int k = 0; k < prepod.Count; k++)
                                    {
                                        if (prepod[k].subg.Contains(list[i].dis[j]) && prepod[k].groups.Contains(list[i].group) && asd == prepod[k].fio)
                                        {
                                            Console.WriteLine(list[i].dis[j] + " - " + list[k].group + " - " + list[i].fio);
                                            Console.ReadKey();
                                        }
                                    }
                                }
                            }
                            if (qwerty == 0)
                            {
                                Console.WriteLine("Долгов нет");
                                Console.ReadKey();
                                qwerty = 0;
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
                    asd = Console.ReadLine();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (asd == list[i].fio)
                        {
                            for (int j = 0; j < list[i].oze.Length; j++)
                            {
                                if (list[i].oze[j] == "0")
                                {
                                    qwerty++;
                                    for (int k = 0; k < prepod.Count; k++) {
                                        if (prepod[k].subg.Contains(list[i].dis[j]) && prepod[k].groups.Contains(list[i].group)){
                                            Console.WriteLine(list[i].dis[j] + " - " + prepod[k].fio);
                                            Console.ReadKey();
                                        }
                                    }
                                }
                            }
                            if (qwerty == 0)
                            {
                                Console.WriteLine("Долгов нет");
                                Console.ReadKey();
                                qwerty = 0;
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
                else if (num == "5")
                {
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}
