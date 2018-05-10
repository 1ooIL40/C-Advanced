using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                var petrolAmount = input[0];
                var distance = input[1];

                if(petrolAmount >= distance)
                {
                    queue.Enqueue(i);
                }

            }
            Console.WriteLine(queue.Peek());
        }
    }
}
