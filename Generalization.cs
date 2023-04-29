using System;
public class GenericArray<T>
{
    private List<T> mas;
    private int maxSize;

    public GenericArray()
    {
        mas = new List<T>();
    }

    public void Adding(T el)
    {
        mas.Add(el);
    }

    public void Deling(T el)
    {
        mas.Remove(el);
    }

    public void Get(T el)
    {
        Console.WriteLine(mas.Contains(el));
    }

    public void Exit()
    {
        foreach(T el in mas)
        {
            Console.WriteLine(el);
        }
    }
}
class SimpGen
{
    static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>();
        GenericArray<string> strArray = new GenericArray<string>();
        intArray.Adding(1);
        intArray.Adding(2);
        intArray.Deling(2);
        intArray.Get(1);
        strArray.Adding("da");
        strArray.Adding("net");
        strArray.Deling("net");
        strArray.Get("da");
        intArray.Exit();
        strArray.Exit();
    }
}
