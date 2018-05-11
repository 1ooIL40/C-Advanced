using System;
using System.Collections.Generic;

namespace _07._Balanced_Parenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            //TODO LOGIK FOR ADD IN QUEUE AND ANOTHER QUEUE
            var queue = new Queue<char>(input.Substring(0, input.Length / 2));
            var stack = new Stack<char>(input.Substring(input.Length / 2)); //have to be queue

            while (queue.Count > 0)
            {
                var yesOrNo = CompareTheQuotes(queue.Dequeue(),stack.Pop());

                if (!yesOrNo)
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }

        public static bool CompareTheQuotes(char first, char second)
        {
            if (first == '{' && second == '}')
            {
                return true;
            }
            if (first == '[' && second == ']')
            {
                return true;
            }
            if (first == '(' && second == ')')
            {
                return true;
            }
            return false;
        }
    }

}
