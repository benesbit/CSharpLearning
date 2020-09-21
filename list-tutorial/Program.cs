using System;
using System.Collections.Generic;

namespace list_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // WorkingWithStrings();
            WorkingWithNumbers();
        }

        static void WorkingWithNumbers() {
            var fibonacciNumbers = new List<int> {1, 1};

            while(fibonacciNumbers.Count < 20)
            {
                var prev = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var prev2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(prev + prev2);
            }

            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

        static void WorkingWithStrings()
        {
            var names = new List<string> {"Ben", "Tony", "Andrew"};

            names.Add("Sparxx");
            names.Add("Alex");
            string removed = names[1];
            names.Remove("Tony");

            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"\nMy name is {names[0]}.");
            Console.WriteLine($"I have added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"I have removed {removed} from the list.");

            Console.WriteLine($"\nThe list has {names.Count} people in it.\n");

            var index = names.IndexOf("Andrew");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            Console.WriteLine("\n");

            names.Sort();
            foreach(var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


            Console.WriteLine("\n");
        }
    }
}
