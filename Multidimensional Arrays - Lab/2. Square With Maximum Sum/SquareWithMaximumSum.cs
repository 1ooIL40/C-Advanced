using System;
using System.Linq;

namespace _2._Square_With_Maximum_Sum
{
    class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            var matrixDimensions = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();

            var rows = matrixDimensions[0];
            var columns = matrixDimensions[1];
            var sum = int.MinValue;

            var maxRowIndex = 0;
            var maxColdIndex = 0;

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                var elements = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row,col] = elements[col];
                }
            }

            //TODO LOGIC for BiggestSubMatrix
        }
    }
}
