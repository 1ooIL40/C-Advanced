using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<int>();

            for (int counter = 0; counter < input.Length; counter++)
            {
                if(input[counter] == '(')
                {
                    stack.Push(counter);
                }

                if(input[counter] == ')')
                {
                    var lenght = counter - stack.Peek() + 1;
                    Console.WriteLine(input.Substring(stack.Pop(), lenght));
                }
            }

        }
    }
}
