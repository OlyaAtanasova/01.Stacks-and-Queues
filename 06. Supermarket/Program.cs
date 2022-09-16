using System;
using System.Collections;
using System.Collections.Generic;

namespace _06._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Peek());
                        names.Dequeue();

                    }
                }
                else
                {
                    names.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
