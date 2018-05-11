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

            var amountOfFlue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                amountOfFlue.Enqueue(input[0] - input[1]);
            }

            for (int i = 0; i < n; i++)
            {
                var distance = new Queue<int>(amountOfFlue);

                var flue = distance.Dequeue();

                while (distance.Count > 0)
                {
                    if (flue >= 0)
                    {
                        flue += distance.Dequeue();
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
            }
        }
    }
}
