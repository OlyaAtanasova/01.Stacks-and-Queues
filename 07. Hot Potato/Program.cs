using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(names);
            int tosses = 1;

            while (queue.Count > 1)
            {
                string currentKid = queue.Dequeue();
                if (tosses == count)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    tosses = 1;
                    continue;
                }
                tosses++;
                queue.Enqueue(currentKid);
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
    
}
