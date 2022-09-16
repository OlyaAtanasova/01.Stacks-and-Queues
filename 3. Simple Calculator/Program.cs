using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] reversed = new string[tokens.Length];

            for (int i = 0, j = tokens.Length - 1; i < tokens.Length; i++, j--)
            {
                reversed[i] = tokens[j];
            }
            
            Stack<string> stack = new Stack<string>(reversed);
            int result = int.Parse(stack.Pop());
            
            while (stack.Count > 0)
            {
                string operation = stack.Pop();
                if (operation == "+")
                {
                    result = result + (int.Parse(stack.Pop()));
                }
                else if (operation == "-")
                {
                    result = result - (int.Parse(stack.Pop()));
                }
            }
            Console.WriteLine(result);

        }
    }
}
