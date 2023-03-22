namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main()
        {
            int[] myInt = new int[5] { 1, 2, 3, 4, 5 };
            while (true)
            {
                int numer;
                for(int i = 0; i < myInt.Length; i++)
                {
                    Console.WriteLine(myInt[i]);
                }
                Console.WriteLine(@"
1) Общее число элементов
2) Число измерений 
3) Бинарный поиск элемента
4) Сортировка
5) Возвращаем строку
6) Значение по указанной позиции
7) Поиск заданного объекта внутри всего одномерного массива
8) Изменяем количество элементов в массиве до указанной величины
9) Изменяем порядок элементов во всем одномерном массиве Array на обратный
10)Очистка Array
11)Выход
");
                string num = Console.ReadLine();
                if (num == "1")
                {
                    Console.WriteLine(myInt.Length);
                    Console.ReadKey();
                }
                else if (num == "2")
                {
                    Console.WriteLine(myInt.Rank);
                    Console.ReadKey();
                }
                else if (num == "3")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Array.BinarySearch(myInt,numer));
                    Console.ReadKey();
                }
                else if (num == "4")
                {
                    Array.Sort(myInt);
                    Console.ReadKey();
                }
                else if (num == "5")
                {
                    Console.WriteLine(myInt.ToString);
                    Console.ReadKey();
                }
                else if (num == "6")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(myInt.GetValue(numer));
                    Console.ReadKey();
                }
                else if (num == "7")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Array.IndexOf(myInt, numer));
                    Console.ReadKey();
                }
                else if (num == "8")
                {
                    numer = Convert.ToInt32(Console.ReadLine());
                    Array.Resize<int>(ref myInt, numer);
                    Console.ReadKey();
                }
                else if (num == "9")
                {
                    Array.Reverse(myInt);
                    Console.ReadKey();
                }
                else if (num == "10")
                {
                    Array.Clear(myInt);
                }
                else if (num == "11")
                {
                    Console.ReadKey(true);
                    Environment.Exit(0);
                }
                Console.Clear();
            }
        }
    }
}
