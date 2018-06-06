using System;
using System.Linq;

namespace _03._Squares_in_Matrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var matrixLenght = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixLenght[0];
            var columns = matrixLenght[1];

            char[,] matrix = new char[rows,columns];

            var result = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var chars = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var firstChar = matrix[row, col];
                    var secondChar = matrix[row, col + 1];
                    var thirdChar = matrix[row + 1, col];
                    var fourthChar = matrix[row + 1, col + 1];

                    if(firstChar == secondChar && firstChar == thirdChar && firstChar == fourthChar)
                    {
                        result += 1;
                    }
                }

            }

            Console.WriteLine(result);

        }
    }
}
