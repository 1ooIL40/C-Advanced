using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var elements = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            var elementsToEnque = int.Parse(input[0]);
            var elementsToDeque = int.Parse(input[1]);
            var searchedElement = int.Parse(input[2]);

            for (int i = 0; i < elementsToEnque; i++)
            {
                queue.Enqueue(elements[i]);
            }

            while (elementsToDeque > 0)
            {
                queue.Dequeue();
                elementsToDeque--;
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if (queue.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
