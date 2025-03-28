using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
     
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());  
        string c = Console.ReadLine();
        bool d = bool.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c + d);
    }
}