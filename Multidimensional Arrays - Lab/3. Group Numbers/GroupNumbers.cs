using System;
using System.Linq;

namespace _3._Group_Numbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();

            int[] arrayLenght = new int[3];

            int[][] jaggedArray = new int[3][];

            foreach (var number in userInput)
            {
                var dividet = Math.Abs(number % 3);

                arrayLenght[dividet]++;
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new  int[arrayLenght[i]];
            }

            int[] indexArray = new int[3];

            foreach (var number in userInput)
            {
                var dividet = Math.Abs(number % 3);

                jaggedArray[dividet][indexArray[dividet]] = number;

                indexArray[dividet]++;
            }


            for (int print = 0; print < jaggedArray.Length; print++)
            {

                for (int num = 0; num < jaggedArray[print].Length; num++)
                {
                    Console.Write(jaggedArray[print][num] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
