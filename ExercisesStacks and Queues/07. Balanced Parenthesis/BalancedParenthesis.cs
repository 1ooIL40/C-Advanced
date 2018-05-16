using System;
using System.Collections.Generic;

namespace _07._Balanced_Parenthesis
{
    class BalancedParenthesis
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            //TODO Fixt the INTERVAL seatch between  the parentheses; 75/100 now
            var openBrackets = new Stack<char>();
            var closedBrackets = new Queue<char>();

            foreach (var bracket in input)
            {
                switch (bracket)
                {
                    case '(':
                        openBrackets.Push('(');
                        break;
                    case '{':
                        openBrackets.Push('{');
                        break;
                    case '[':
                        openBrackets.Push('[');
                        break;
                    case ')':
                        closedBrackets.Enqueue(')');
                        break;
                    case '}':
                        closedBrackets.Enqueue('}');
                        break;
                    case ']':
                        closedBrackets.Enqueue(']');
                        break;
                }
                if (openBrackets.Count != 0 && closedBrackets.Count != 0)
                {
                    if (CompareTheQuotes(openBrackets.Peek(), closedBrackets.Peek()))
                    {
                        openBrackets.Pop();
                        closedBrackets.Dequeue();
                    }
                }
            }

            if (openBrackets.Count == 0 && closedBrackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
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
