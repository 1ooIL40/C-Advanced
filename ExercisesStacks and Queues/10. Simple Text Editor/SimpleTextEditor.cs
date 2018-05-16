using System;
using System.Collections.Generic;

namespace _10._Simple_Text_Editor
{
    class SimpleTextEditor
    {
        private static Stack<char> stack = new Stack<char>();

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var opperations = Console.ReadLine().Split();

                var commands = int.Parse(opperations[0]);

                switch (commands)
                {
                    case 1:
                        foreach (var ch in opperations[1])
                        {
                            stack.Push(ch);
                        }

                        break;
                    case 2:
                        var charsToRemove = int.Parse(opperations[1]);

                        Erases(charsToRemove);
                        break;
                    case 3:
                        var index = int.Parse(opperations[1]);

                        Console.WriteLine(returnElementAtIndex(index));
                        break;
                    case 4:
                        //TODO LOGIC FOR "UNDO"

                        break;
                }
            }
        }

        public static char returnElementAtIndex(int index)
        {
            var findTheElementAtIndex = new Queue<char>(stack);

            while (findTheElementAtIndex.Count > index)
            {
                findTheElementAtIndex.Dequeue();
            }

            return findTheElementAtIndex.Peek();
        }

        public static Stack<char> Erases(int opperations)
        {
            while (opperations > 0) 
            {
                stack.Pop();
                opperations--;
            }
            return stack;
        }
    }
}
