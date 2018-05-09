using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues___Lab
{
    class ReverseStrings
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            foreach (var character in input)
            {
                stack.Push(character);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
