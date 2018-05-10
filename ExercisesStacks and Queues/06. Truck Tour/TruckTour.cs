using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class TruckTour
    {
        //TODO Fix Time LIMIT on Test 2
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var amountOfFlue = new Queue<int>();
            var distance = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                amountOfFlue.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }

            for (int i = 0; i < n; i++)
            {
                var workOnTheQueueFlue = new Queue<int>(amountOfFlue);
                var workOnTheQueueDistance = new Queue<int>(distance);

                var flue = workOnTheQueueFlue.Dequeue() - workOnTheQueueDistance.Dequeue();

                while (workOnTheQueueFlue.Count > 0)
                {
                    if (flue >= 0)
                    {
                        flue += workOnTheQueueFlue.Dequeue();
                        flue -= workOnTheQueueDistance.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }

                if(flue >= 0)
                {
                    Console.WriteLine(i);
                    return;
                }

                amountOfFlue.Enqueue(amountOfFlue.Dequeue());
                distance.Enqueue(distance.Dequeue());

            }
        }
    }
}
