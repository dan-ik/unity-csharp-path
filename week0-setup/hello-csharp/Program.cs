using System;

class Program
{
    static int a = 55;
    static int b = 9;
    static string name = "Данил";
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static void Greet (string name)
    {
        Console.WriteLine($"Привет, {name}!");
    }
    static void Main(string[] args)
    {
        int total = 0;
        for (int i = 1; i <= 5; i++)
        {
            total += Sum(i, i * 2);
        }
        Console.WriteLine($"Total= {total}");
        Greet(name);
        if (a < b)
        {
            Console.WriteLine("a меньше b");
        }
        else
        {
            Console.WriteLine("a больше b");
            int result = Sum(a, b);
            Console.WriteLine(result);
        }

    }
}
