using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hot_Potato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var childrens = Console.ReadLine().Split(' ');
            var hotPotatoCounter = int.Parse(Console.ReadLine());

            var queues = new Queue<string>(childrens);

            while (queues.Count != 1)
            {
                var leaveCounter = 1;

                while(leaveCounter != hotPotatoCounter)
                {
                    var passed = queues.Dequeue();
                    queues.Enqueue(passed);
                    leaveCounter++;
                }
                Console.WriteLine($"Removed {queues.Dequeue()}");
            }
            Console.WriteLine($"Last is {queues.Dequeue()}");
        }
    }
}
