using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Recursion
    {
        public static int SumToNRecursive(int n) // 1
        {
            if (n <= 0)
            {
                return n;
            }

            return n + SumToNRecursive(n-1);
        }

        public static int NFactorialRecursive(int n) // 2
        {
            if (n <= 0)
            {
                return 1;
            }

            return n * NFactorialRecursive(n-1);
        }

        public static int NOddFactorialRecursive(int n) // 3
        {
            if (n <= 0)
            {
                return 1;
            }

            if (n % 2 != 0)
            {
                return n * NOddFactorialRecursive(n-1);
            }
            else
            {
                return NOddFactorialRecursive(n-1);
            }
        }

        public static int DigitCountRecursive(int n) // 4
        {
            if (n < 10)
            {
                return 1;
            }

            return 1 + DigitCountRecursive(n/10);
        }

        public static int RawRecursiveDivision(int a, int b)
        {
            if (a < 0)
            {
                return 0;
            }

            return 1 + RawRecursiveDivision(a-b, b);
        }

    }
}
