using System;

namespace _4._Pascal_Triangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            var triangleHeight = int.Parse(Console.ReadLine());

            long[][] jeggedTriangleArray = new long[triangleHeight][];

            for (int triangleRows = 0; triangleRows < jeggedTriangleArray.Length; triangleRows++)
            {
                for (int triangleColumns = 0; triangleColumns <= triangleRows; triangleColumns++)
                {
                    jeggedTriangleArray[triangleRows] = new long[triangleColumns + 1];
                }
            }


            for (int counter = 0; counter < jeggedTriangleArray.Length; counter++)
            {
                for (int addNums = 0; addNums <= jeggedTriangleArray[counter].Length - 1; addNums++)
                {
                    jeggedTriangleArray[counter][0] = 1;
                    jeggedTriangleArray[counter][jeggedTriangleArray[counter].Length - 1] = 1;

                    if(addNums >= 1 && addNums < jeggedTriangleArray[counter].Length - 1)
                    {
                        var numberToAdd = jeggedTriangleArray[counter - 1][addNums - 1] + 
                            jeggedTriangleArray[counter - 1][addNums];

                        jeggedTriangleArray[counter][addNums] = numberToAdd;
                    }
                }
            }

            for (int rowsToPrint = 0; rowsToPrint < jeggedTriangleArray.Length; rowsToPrint++)
            {
                for (int colmsToPrint = 0; colmsToPrint < jeggedTriangleArray[rowsToPrint].Length; colmsToPrint++)
                {
                    var printResult = jeggedTriangleArray[rowsToPrint][colmsToPrint];
                    Console.Write(printResult + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
