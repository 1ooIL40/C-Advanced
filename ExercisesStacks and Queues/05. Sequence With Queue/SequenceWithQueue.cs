using System;
using System.Collections.Generic;

namespace _05._Sequence_With_Queue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long startingNumber = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            var resultQueue = new Queue<long>();

            queue.Enqueue(startingNumber);
            resultQueue.Enqueue(startingNumber);

            for (int i = 1; i <= 50; i += 3)
            {
                var num = queue.Peek();
                var firstSequnce = num + 1;
                var secondSequnce =  2 * num + 1;
                var thirdSequnce = num + 2;

                queue.Enqueue(firstSequnce);
                queue.Enqueue(secondSequnce);
                queue.Enqueue(thirdSequnce);

                resultQueue.Enqueue(firstSequnce);
                resultQueue.Enqueue(secondSequnce);
                resultQueue.Enqueue(thirdSequnce);

                queue.Dequeue();
            }

            while (resultQueue.Count > 2)
            {
                Console.Write($"{resultQueue.Dequeue()} ");
            }
        }
    }
}
