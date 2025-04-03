using System;
using System.Collections.Generic;

namespace Basic
{
    class Program
    {


        public static async Task Main()
        {

            Console.WriteLine("XDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");

        }
    }
}

/*        public static void Main(string[] args)
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
                                select x ).Take(5);

            foreach (int x in numQ)
            {

                Console.WriteLine(x);

            }

        

        }
    }

}

✅ Exercise 14: "Multi-threading & Async/Await (Performance)"

Write a function that simulates a long-running task using Task.Delay(2000).

Run it asynchronously using async and await.
 
 🔥 Additional Exercises: Events & Delegates (Deep Dive!)
✅ Exercise 15: "Basic Delegate Example"

Define a delegate public delegate void MyDelegate(string message);.

Create a method that prints "Hello, " + message.

Assign it to a delegate variable and invoke it.

✅ Exercise 16: "Multicast Delegates (Chaining Methods)"

Create two methods:

SayHello() → Prints "Hello!"

SayGoodbye() → Prints "Goodbye!"

Use a multicast delegate so both run when invoked.

✅ Exercise 17: "Events & Subscribers"

Create an EventHandler in a GameManager class.

Subscribe a Player object to listen to "OnGameStart".

Trigger the event in GameManager and see the Player's reaction.

✅ Exercise 18: "Custom Event with Arguments"

Define an event OnPlayerDamaged(int damageAmount).

Trigger it when a player takes damage.

Make multiple subscribers react differently (e.g., UI update, sound effect).

✅ Exercise 19: "Lambdas & Anonymous Methods"

Use a lambda expression to define a delegate inline.

Compare it with a regular named method.

📜 Full Roadmap (For Easy Tracking!)
(Including all previous exercises)

🔥 Roadmap: C# & Unity Mastery
Phase 1: Mastering C# Through Exercises
📌 Goal: Move from Java → C# smoothly, learn Unity-relevant C# concepts, and build a text-based RPG as a final project.

🟢 Level 1: C# Syntax & Basics (Java → C# Warm-up)
✅ Exercise 1: "Hello, C#!"
✅ Exercise 2: "C# Variables & Types"
✅ Exercise 3: "C# vs Java Loops & Conditionals"
✅ Exercise 4: "C# Arrays & Lists"
✅ Exercise 5: "C# Functions & Overloading"

🟡 Level 2: Object-Oriented Programming in C# (Core Unity Concepts)
✅ Exercise 6: "Classes & Objects"
✅ Exercise 7: "Encapsulation (Properties vs Getters/Setters in Java)"
✅ Exercise 8: "Inheritance & Polymorphism"
✅ Exercise 9: "Interfaces & Abstract Classes (C# vs Java)"
✅ Exercise 10: "Delegates & Events (Like Unreal’s Events)"

🔴 Level 3: C# Intermediate Concepts for Unity
✅ Exercise 11: "Static vs Instance Members"
✅ Exercise 12: "LINQ (Advanced List Manipulation)"
✅ Exercise 13: "File Handling (Save & Load)"
✅ Exercise 14: "Multi-threading & Async/Await (Performance)"
✅ Exercise 15: "Basic Delegate Example"
✅ Exercise 16: "Multicast Delegates (Chaining Methods)"
✅ Exercise 17: "Events & Subscribers"
✅ Exercise 18: "Custom Event with Arguments"
✅ Exercise 19: "Lambdas & Anonymous Methods"*/
