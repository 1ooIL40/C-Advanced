using System;
using System.Linq;

namespace _01._Matrix_of_Palindromes
{
    class MatrixOfPalindromes
    {
        public static  char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        static void Main(string[] args)
        {
            var rowsAndColumns = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();


            var rows = rowsAndColumns[0];
            var columns = rowsAndColumns[1];

            string[,] matrix = new string[rows, columns];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = Polindromes(row, col);
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        public static string Polindromes(int row, int col)
        {
            var result = "";

            result = alphabet[row].ToString() + alphabet[col + row].ToString() + alphabet[row].ToString();

            return result;
        }
    }
}
