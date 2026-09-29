using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class VoidRecursion
    {
        public static void PrintBetweenLetters(char lt1, char lt2) // 24
        {
            if (lt1 <= lt2)
            {
                Console.Write(lt1);
                PrintBetweenLetters((char)(lt1 + 1), lt2);
            }
        }

        public static void PrintMultiples(int n)
        {
            int i = 1;
            PrintMultiples(n, i);
        }

        private static void PrintMultiples(int n, int i) // 25
        {
            if (n % i == 0)
            {
                Console.Write($"{i}, ");
            }
            if (i < n)
            {
                PrintMultiples(n, i + 1);
            }
        }

        public static void PrintEvenDigits(int n) // 26
        {
            if (n % 2 == 0)
            {
                Console.Write(n%10);
            }
            if (n > 9)
            {
                PrintEvenDigits(n / 10);
            }
        }

        public static void PrintMultyTable(int row = 1, int col = 1) // 27
        {
            Console.Write($"{row * col, 4}");

            if (col < 10)
            {
                PrintMultyTable(row, col + 1);
            }
            else if (row < 10)
            {
                Console.WriteLine("\n");
                PrintMultyTable(row + 1, 1);
            }
        }

        public static void PrintGapSeries(int a1, int d, int n) // 28
        {
            Console.Write($"{a1, 4}");

            if (n > 1)
            {
                PrintGapSeries(a1 + d, d, n - 1);
            }
        }

        public static void PrintStrangeSeries(int n, int currentNum = 1, int d = 1) // 29
        {
            Console.WriteLine(currentNum);

            if (n > 1)
            {
                PrintStrangeSeries(n-1, currentNum+d, d + 1);
            }
        }

        public static void PrintUpDownSeries(int n, int currentNum = 4, bool up = false) // 30
        {
            Console.WriteLine(currentNum);
            int d = up ? 2 : -1;

            if (n > 1)
            {
                PrintUpDownSeries(n-1, currentNum + d, !up);
            }
        }

        public static void PrintEvenArray(int[] arr, int n = 0) // 31
        {
            if (n % 2 == 0)
            {
                Console.WriteLine(arr[n]);
            }

            if (n < arr.Length - 1)
            {
                PrintEvenArray(arr, n + 1);
            }
        }

        public static void PrintShrinkingArray(int[] arr, int n = 0) // 32
        {
            if (n < arr.Length - 1)
            {
                if (arr[n] < arr[n+1])
                {
                    Console.WriteLine(arr[n]);
                }

                PrintShrinkingArray(arr, n + 1);
            }
        }

        public static void PrintTwoDimArray(int[,] arr, int row = 0, int col = 0) // 33
        {
            Console.Write($"{arr[row, col], 3}");

            if (col < arr.GetLength(1) - 1)
            {
                PrintTwoDimArray(arr, row, col + 1);
            }
            else if (row < arr.GetLength(0) - 1)
            {
                Console.WriteLine();
                PrintTwoDimArray(arr, row + 1, 0);
            }
        }

        public static int FindMaxInRow(int[,] arr, int row, int col = 0, int max = 0) // 34 helper func
        {
            if (col < arr.GetLength(1))
            {
                if (col == 0)
                {
                    max = arr[row, col];
                }
                else if (arr[row, col] > max)
                {
                    max = arr[row, col];
                }

                return FindMaxInRow(arr, row, col + 1, max);
            }
            else
            {
                return max;
            }
        }

        public static void PrintMaxCols(int[,] arr, int row = 0) // 34
        {
            Console.WriteLine(FindMaxInRow(arr, row));

            if (row < arr.GetLength(0) - 1)
            {
                PrintMaxCols(arr, row + 1);
            }
        }

    }
}
