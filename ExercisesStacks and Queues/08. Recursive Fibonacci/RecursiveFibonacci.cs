using System;

namespace _08._Recursive_Fibonacci
{
    class RecursiveFibonacci
    {
        private static long[] memo;

        static void Main(string[] args)
        {
            var inputNumber = long.Parse(Console.ReadLine());
            inputNumber -= 1;

            memo = new long[inputNumber + 1];

            var result = getFibonacci(inputNumber);

            Console.WriteLine(result);
        }

        private static long getFibonacci(long n)
        {
            if (n <= 1)
            {
                return 1;
            }

            if (memo[n] != 0)
            {
                return memo[n];
            }

            memo[n] = getFibonacci(n - 1) + getFibonacci(n - 2);
            return memo[n];
        }
    }
}
