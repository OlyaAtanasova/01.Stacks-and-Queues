using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();
            foreach (var item in input)
            {
                stack.Push(item);
            }

            while (true)
            {
            string command = Console.ReadLine().ToLower();
                if (command == "end")
                {
                    break;
                }
                string[] tokens = command.Split(" ");
                string action = tokens[0];
                if (action == "add")
                {
                    int firstNum = int.Parse(tokens[1]);
                    int secondNum = int.Parse(tokens[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (action == "remove")
                {
                    int num = int.Parse(tokens[1]);
                    if (stack.Count < num)
                    {
                        continue;
                    }
                    for (int i = 0; i < num; i++)
                    {
                        stack.Pop();
                    }
                }

            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
