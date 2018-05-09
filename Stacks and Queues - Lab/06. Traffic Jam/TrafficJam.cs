using System;
using System.Collections.Generic;

namespace _06._Traffic_Jam
{
    class TrafficJam
    {
        static void Main(string[] args)
        {
            var numberOfCars = int.Parse(Console.ReadLine());
            var input = Console.ReadLine();

            var queues = new Queue<string>();
            var numberOfCarsPassed = 0;

            while (input != "end")
            {
                if(input == "green")
                {
                    var nCars = Math.Min(queues.Count, numberOfCars);

                    for (int counter = 0; counter < nCars; counter++)
                    {
                        Console.WriteLine($"{queues.Dequeue()} passed!");
                        numberOfCarsPassed++;
                    }
                }
                else
                {
                    queues.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{numberOfCarsPassed} cars passed the crossroads.");
        }
    }
}
