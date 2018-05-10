using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var inputIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();

            var integerN = int.Parse(input[0]);
            var integerS = int.Parse(input[1]);
            var integerX = int.Parse(input[2]);


            for (int count = 0; count < integerN; count++)
            {
                stack.Push(inputIntegers[count]);
            }

            while (stack.Count > 0 && integerS > 0)
            {
                stack.Pop();
                integerS--;
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(integerX))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
