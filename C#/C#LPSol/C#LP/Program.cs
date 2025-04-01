using System;
using System.Collections.Generic;

namespace Basic
{
    class Program
    {

        public static void Main(string[] args)
        {

            int Add(int a, int b)
            {

                return a + b;

            }

            int Add1(int a, int b, int c)
            {

                return a + b + c;

            }

            double Add2(double a, double b)
            {

                return a * b;

            }
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

            foreach (int i in list)
            {

                Console.WriteLine("\n" + i);

            }
            //12
            int[] nums = { 3, 7, 8, 9, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24 };

            var numQ = (from x in nums
                                where ((x % 2) == 0)
                                orderby x descending
                                select x ).Take(3);

            foreach (int x in numQ)
            {

                Console.WriteLine(x);

            }

        

        }
    }

}












/* ✅ Exercise 10: "Delegates & Events (Like Unreal’s Events)"

Create a delegate that represents a function: OnTakeDamage(int amount).

Subscribe a method to this delegate and call it when a character takes damage.

🔴 Level 3: C# Intermediate Concepts for Unity
✅ Exercise 11: "Static vs Instance Members"

Create a static GameManager class that tracks the number of players.

Compare static members in C# vs Java.

✅ Exercise 12: "LINQ (Advanced List Manipulation)"

Given a list of numbers, use LINQ to:

Find even numbers

Sort them

Return the highest value

✅ Exercise 13: "File Handling (Save & Load)"

Write a JSON save system that stores Player stats to a file and loads them back.

✅ Exercise 14: "Multi-threading & Async/Await (Performance)"

Write a function that simulates a long-running task using Task.Delay(2000).

Run it asynchronously using async and await.*/