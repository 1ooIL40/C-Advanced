using System;
using System.Collections.Generic;

namespace _09._Stack_Fibonacci
{
    class StackFibonacci
    {
        static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine());

            var stackOfFibonacciNumbers = new Stack<long>();
            stackOfFibonacciNumbers.Push(0);
            stackOfFibonacciNumbers.Push(1);

            for (int i = 1; i < inputNumber; i++)
            {

                var lastNumber = stackOfFibonacciNumbers.Pop();
                var previusNumber = stackOfFibonacciNumbers.Pop();

                stackOfFibonacciNumbers.Push(lastNumber);
                stackOfFibonacciNumbers.Push(lastNumber + previusNumber);

            }

            Console.WriteLine(stackOfFibonacciNumbers.Peek());
        }
    }
}
