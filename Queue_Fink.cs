using System.Collections;
using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main()
        {
            Queue myInt = new Queue();
            while (true)
            {
                int numer, count;
                
                Console.WriteLine(myInt);
                
                Console.WriteLine(@"
1) Очистка
2) Входит ли элемент в очередь 
3) Возвращение объекта без его удаление
4) Возвращение и удаление объекта
5) Добавить элемент
6) Равен ли объект с текущим объектом
7) Перечисление элементов
8) Хэш-функция
9) Возвращение Type
10) Возвращение строки
11) Выход
");

                string num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        myInt.Clear();
                        Console.ReadKey();
                        break;
                    case "2":
                        num = Console.ReadLine();
                        Console.WriteLine(myInt.Contains(num));
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine(myInt.Peek());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine(myInt.Dequeue());
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        myInt.Enqueue(num);
                        Console.ReadKey();
                        break;
                    case "6":
                        num = Console.ReadLine();
                        Console.WriteLine(myInt.Equals(num));
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine(myInt.GetEnumerator());
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine(myInt.GetHashCode());
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine(myInt.GetType());
                        Console.ReadKey();
                        break;
                    case "10":
                        Console.WriteLine(myInt.ToString());
                        Console.ReadKey();
                        break;

                    case "11":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
