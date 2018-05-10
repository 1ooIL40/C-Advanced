using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_Reverse_Numbers_with_a_Stack
{
    class ReverseNumbersWithAStack
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ');

            var stack = new Stack<string>(numbers);

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}
