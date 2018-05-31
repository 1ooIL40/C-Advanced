using System;
using System.Linq;

namespace _02._Diagonal_Difference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            var matrixDimentions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixDimentions, matrixDimentions];


            for (int rows = 0; rows < matrixDimentions; rows++)
            {
                var columsOfIntegers = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int colms = 0; colms < matrixDimentions; colms++)
                {
                    matrix[rows, colms] = columsOfIntegers[colms];
                }

            }

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;
            var difference = 0;



            for (int sum = 0; sum < matrixDimentions; sum++)
            {
                primaryDiagonalSum += matrix[sum, sum];
                secondaryDiagonalSum += matrix[sum, matrixDimentions - 1 - sum];
            }

            difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(difference);
        }
    }
}
