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
            if (a < b)
            {
                return 0;
            }

            return 1 + RawRecursiveDivision(a-b, b);
        }

        public static int RecursiveModulo(int a, int b)
        {
            if (a < b)
            {
                return a;
            }

            return RecursiveModulo(a-b, b);
        }

        public static bool IsMultiple(int a, int b)
        {
            if (a < 0)
            {
                return false;
            }

            if (a == 0)
            {
                return true;
            }

            return IsMultiple(a - b, b);
        }

        public static bool IsPrimeRecursive(int n, int divider = 9)
        {
            if (divider <= 1)
            {
                return true;
            }

            if (IsMultiple(n, divider))
            {
                return false;
            }
            else
            {
                return IsPrimeRecursive(n, divider - 1);
            }
        }

        // Checks if all digits are odd or all digits are even, if neither of these FALSE
        public static bool NeverOddOrEven(int n) // https://www.youtube.com/watch?v=XY3b4kVAV2Y
        {
            if (n < 10)
            {
                return true;
            }

            if ((n % 2 == 0) != ((n / 10) % 2 == 0))
            {
                return false;
            }

            return NeverOddOrEven(n/10);
        }

        public static int MultipliedByToUpToN(int n)
        {
            if (n <= 1)
            {
                return n * 2;
            }

            if (n % 2 == 0)
            {
                return n * n + MultipliedByToUpToN(n-1);
            }
            else
            {
                return n * 2 + MultipliedByToUpToN(n-1);
            }
        }

        public static double ChainToN(int n, int count = 1, int organ = 1)
        {
            if (count > n)
            {
                return 0;
            }

            if (count % 2 == 0)
            {
                return -Math.Sqrt(organ) + ChainToN(n, count + 1, organ + 2);
            }
            else
            {
                return organ + ChainToN(n, count + 1, organ + 2);
            }

        }

        // public static int MultiplesUpToN2(int n,)
    }
}
