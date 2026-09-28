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
    }
}
