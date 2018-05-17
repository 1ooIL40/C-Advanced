using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Simple_Text_Editor
{
    class SimpleTextEditor
    {
        private static Stack<char> stack = new Stack<char>();
        private static Stack<string> forUndo = new Stack<string>();

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var opperations = input.Split();

                var commands = int.Parse(opperations[0]);

                switch (commands)
                {
                    case 1:
                        foreach (var ch in opperations[1])
                        {
                            stack.Push(ch);
                        }
                        forUndo.Push(input);
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

                        UNDO();

                        break;
                }
            }
        }

        private static void UNDO()
        {
            var lastCommand = forUndo.Pop().Split();

            switch (lastCommand[0])
            {
                case "1":
                    for (int i = 0; i < lastCommand[1].Length; i++)
                    {
                        stack.Pop();
                    }
                    break;
                case "2":

                    var addIn = lastCommand[1].ToCharArray().Reverse();

                    foreach (var ch in addIn)
                    {
                        stack.Push(ch);
                    }
                    break;
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
            var rememberChars = string.Empty;

            while (opperations > 0)
            {
                rememberChars += stack.Pop().ToString();
                opperations--;
            }

            forUndo.Push($"2 {rememberChars}");
            return stack;
        }
    }
}
