using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Simple_Calculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Reverse();

            var stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                var firstOperand = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var secondOperand = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+":
                        stack.Push((firstOperand + secondOperand).ToString());
                        break;
                    case "-":
                        stack.Push((firstOperand - secondOperand).ToString());
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
