using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class SumMatrixElements
    {
        static void Main(string[] args)
        {
            var matrixDimensions = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();

            var row = matrixDimensions[0];
            var col = matrixDimensions[1];
            var sum = 0;

            int[,] matrix = new int[row, col];

            for (int rows = 0; rows < row; rows++)
            {
                var matrixNumbers = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();

                for (int columns = 0; columns < col; columns++)
                {
                    matrix[rows, columns] = matrixNumbers[columns];
                    sum += matrixNumbers[columns];
                }
            }

            Console.WriteLine(row);
            Console.WriteLine(col);
            Console.WriteLine(sum);
        }
    }
}
