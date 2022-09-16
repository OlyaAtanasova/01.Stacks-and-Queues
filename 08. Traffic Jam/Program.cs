using System;
using System.Collections;
using System.Collections.Generic;

namespace _08._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int passed = 0;
            while(command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Peek()} passed!");
                            passed++;
                            cars.Dequeue();
                        }
                        
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                    command = Console.ReadLine();
            }
            Console.WriteLine($"{passed} cars passed the crossroads.");
        }
    }
}
