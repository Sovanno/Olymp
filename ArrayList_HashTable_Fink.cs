using System.Collections;
using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main()
        {
            ArrayList myInt = new ArrayList();
            Hashtable hashtable = new Hashtable();
            while (true)
            {
                int numer, count;
                for (int i = 0; i < myInt.Count; i++)
                {
                    Console.WriteLine(myInt[i]);
                }
                for (int i = 0; i < hashtable.Count; i++)
                {
                    Console.WriteLine(hashtable[i]);
                }
                Console.WriteLine(@"
1) ArrayList
2) Hashtable
3) Exit

");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.WriteLine(@"
1) Добавление элемента
2) Бинарный поиск
3) Часть Коллекции
4) Индекс первого вхождения элемента
5) Только для чтения 
6) Удаление части коллекции
7) Revers
8) Sort
9) Колличество элементов
10) Clear
");
                        num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                num = Console.ReadLine();
                                myInt.Add(num);
                                Console.ReadKey();
                                break;
                            case "2":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.BinarySearch(num));
                                Console.ReadKey();
                                break;
                            case "3":
                                numer = Convert.ToInt32(Console.ReadLine());
                                count = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(myInt.GetRange(numer, count));
                                Console.ReadKey();
                                break;
                            case "4":
                                num = Console.ReadLine();
                                Console.WriteLine(myInt.IndexOf(num));
                                Console.ReadKey();
                                break;
                            case "5":
                                Console.WriteLine(ArrayList.ReadOnly(myInt));
                                Console.ReadKey();
                                break;
                            case "6":
                                numer = Convert.ToInt32(Console.ReadLine());
                                count = Convert.ToInt32(Console.ReadLine());
                                myInt.RemoveRange(numer, count);
                                Console.ReadKey();
                                break;
                            case "7":
                                myInt.Reverse();
                                Console.ReadKey();
                                break;
                            case "8":
                                myInt.Sort();
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(myInt.Count);
                                Console.ReadKey();
                                break;
                            case "10":
                                myInt.Clear();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine(@"
1) Добавить key and value
2) Проверка, содержится ли ключ в hachtable
3) Проверка, содержится ли значение в hachtable
4) GetEnumerator
5) GetHash
6) GetType
7) Удаление элементов
8) Десериализация
9) Возвращение синхронизированной оболочки
10) Очистка
");
                        num = Console.ReadLine();
                        switch (num)
                        {
                            case "1":
                                numer = Convert.ToInt32(Console.ReadLine());
                                count = Convert.ToInt32(Console.ReadLine());
                                hashtable.Add(numer, count);
                                Console.ReadKey();
                                break;
                            case "2":
                                numer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(hashtable.Contains(numer));
                                Console.ReadKey();
                                break;
                            case "3":
                                count = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(hashtable.ContainsValue(count));
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.WriteLine(hashtable.GetEnumerator());
                                Console.ReadKey();
                                break;
                            case "5":
                                numer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(numer.GetHashCode());
                                Console.ReadKey();
                                break;
                            case "6":
                                numer = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(numer.GetType);
                                Console.ReadKey();
                                break;
                            case "7":
                                numer = Convert.ToInt32(Console.ReadLine());
                                hashtable.Remove(numer);
                                Console.ReadKey();
                                break;
                            case "8":
                                Console.WriteLine(hashtable.OnDeserialization);
                                Console.ReadKey();
                                break;
                            case "9":
                                Console.WriteLine(hashtable.IsSynchronized);
                                Console.ReadKey();
                                break;
                            case "10":
                                hashtable.Clear();
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
