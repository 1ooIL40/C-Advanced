using System;
using System.Collections.Generic;

namespace _03._Decimal_to_Binary_Converter
{
    class DecimalToBinaryConverter
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            if (number == 0)
            {
                Console.WriteLine(number);
                return;
            }

            while (number > 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
