using System;

class Program
{

    int Add(int a, int b)
    {

        return a + b;

    }

    int Add(int a, int b, int c)
    {

        return a + b + c;

    }

    double Add(double a, double b)
    {

        return a * b;

    }



    static void Main(string[] args)
    {
        Console.WriteLine("Hello world");
     
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());  
        string c = Console.ReadLine();
        bool d = bool.Parse(Console.ReadLine());

        Console.WriteLine(a + b + c + d);

        Console.WriteLine($"wha ha hape {a} to lady jane {b} {c}");

        while (a < 10)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(c);
            }
            a++;
        }

        List<int> list = new List<int>();
        
        list.Add(a);
        list.Add(5);

        foreach (int i in list) {
            
            Console.WriteLine("\n"+i);
        
        }
    
    
    }
      
}