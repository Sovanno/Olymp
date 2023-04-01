using System.Collections;
using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Class1
    {
        static void Main()
        {
            Stack myInt = new Stack();
            Stack myStack = new Stack();
            while (true)
            {
                int numer, count;
                
                Console.WriteLine(myInt);
                
                Console.WriteLine(@"
1) Очистка
2) Входит ли элемент в стэк
3) Возвращение объекта без его удаление
4) Возвращение и удаление объекта
5) Добавить элемент
6) Скобки :)
7) Выход
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
                        Console.WriteLine(myInt.Pop());
                        Console.ReadKey();
                        break;
                    case "5":
                        num = Console.ReadLine();
                        myInt.Push(num);
                        Console.ReadKey();
                        break;
                    case "6":
                        object b;
                        int value = 0;
                        num = Console.ReadLine();
                        foreach(var s in num)
                        {
                            if (s == '(' || s == '{' || s == '[')
                            {
                                myStack.Push(s);
                            }
                            else if (myStack.Count != 0)
                            {
                                    b = myStack.Peek();
                                    if (s == ')' && b is '(')
                                    {
                                        myStack.Pop();
                                    }
                                    if (s == ']' && b is '[')
                                    {
                                        myStack.Pop();
                                    }
                                    if (s == '}' && b is '{')
                                    {
                                        myStack.Pop();
                                    }
                            }
                            else
                            {
                                Console.WriteLine("Нет");
                                Console.ReadKey();
                                value++;
                                break;
                            }
                        }
                        if (value == 0 && myStack.Count == 0)
                        {
                            Console.WriteLine("Да");
                            Console.ReadKey();
                        }
                        else if (value == 0 && myStack.Count != 0)
                        {
                            Console.WriteLine("Нет");
                            Console.ReadKey();
                        }
                        break;

                    case "7":
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
        }
    }
}
