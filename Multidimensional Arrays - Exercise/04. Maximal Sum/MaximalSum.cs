using System;
using System.Linq;

namespace _04._Maximal_Sum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var matrixLenght = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixLenght[0];
            var columns = matrixLenght[1];

            int[,] matrix = new int[rows, columns];

            var maxSum = 0;
            var rowIndex = 0;
            var colIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var firstNumber = matrix[row, col];
                    var secondNumber = matrix[row, col + 1];
                    var thirdNumber = matrix[row, col + 2];
                    var fourthNumber = matrix[row + 1, col];
                    var fifthNumber = matrix[row + 1, col + 1];
                    var sixthNumber = matrix[row + 1, col + 2];
                    var seventhNumber = matrix[row + 2, col];
                    var eighthNumber = matrix[row + 2, col + 1];
                    var ninthNumber = matrix[row + 2, col + 2];

                    var sum = firstNumber + secondNumber + thirdNumber
                        + fourthNumber + fifthNumber + sixthNumber
                        + seventhNumber + eighthNumber + ninthNumber;

                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }

            }

            Console.WriteLine($"Sum = {maxSum}");

           Console.WriteLine($"{matrix[rowIndex, colIndex]} {matrix[rowIndex, colIndex + 1]} {matrix[rowIndex, colIndex + 2]}");
Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} {matrix[rowIndex + 1, colIndex + 1]} {matrix[rowIndex + 1, colIndex + 2]}");
Console.WriteLine($"{matrix[rowIndex + 2, colIndex]} {matrix[rowIndex + 2, colIndex + 1]} {matrix[rowIndex + 2, colIndex + 2]}");
        }
    }
}
