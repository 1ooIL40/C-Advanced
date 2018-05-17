using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10._Simple_Text_Editor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var oldVersions = new Stack<string>();

            var text = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var commandInput = input.Split();

                var commands = int.Parse(commandInput[0]);

                switch (commands)
                {
                    case 1:
                        oldVersions.Push(text.ToString());
                        string newText = commandInput[1];
                        text.Append(newText);
                        break;
                    case 2:
                        oldVersions.Push(text.ToString());
                        var length = int.Parse(commandInput[1]);
                        text.Remove(text.Length - length, length);
                        break;
                    case 3:
                        var index = int.Parse(commandInput[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                }
            }
        }
    }
}
