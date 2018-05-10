using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            var integerN = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxElementStack = new Stack<int>();

            maxElementStack.Push(int.MinValue);

            for (int count = 0; count < integerN; count++)
            {
                var querys = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int action = querys[0];

                switch (action)
                {
                    case 1:
                        int elementToPush = querys[1];
                        stack.Push(elementToPush);
                        if (elementToPush >= maxElementStack.Peek())
                        {
                            maxElementStack.Push(elementToPush);
                        }

                        break;
                    case 2:
                        int popedElement = stack.Pop();
                        if (popedElement == maxElementStack.Peek())
                        {
                            maxElementStack.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = maxElementStack.Peek();
                        Console.WriteLine(maxElement);
                        break;
                }

            }
        }
    }
}
