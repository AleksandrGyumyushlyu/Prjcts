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

        public static int RawRecursiveDivision(int a, int b) // 5
        {
            if (a < b)
            {
                return 0;
            }

            return 1 + RawRecursiveDivision(a-b, b);
        }

        public static int RecursiveModulo(int a, int b) // 6
        {
            if (a < b)
            {
                return a;
            }

            return RecursiveModulo(a-b, b);
        }

        public static bool IsMultiple(int a, int b) // 7
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

        public static bool IsPrimeRecursive(int n, int divider = 9) // 8
        {
            if (divider <= 1)
            {
                return true;
            }

            if (divider != n && IsMultiple(n, divider))
            {
                return false;
                Console.WriteLine(divider);
            }
            else
            {
                return IsPrimeRecursive(n, divider - 1);
            }
        }

        // Checks if all digits are odd or all digits are even, if neither of these FALSE (Task   9)
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

        public static int MultipliedByToUpToN(int n) // 10
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

        public static double ChainToN(int n, int count = 1, int organ = 1) // 11
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

        public static int MultiplesUpToN2(int n1, int n2, int multiple = 1) // 12
        {
            if (multiple * n1 > n2)
            {
                return 0;
            }

            return multiple * n1 + MultiplesUpToN2(n1, n2, multiple+1);
        }

        public static int QuadricSequenceNum(int n) // 13 a
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                return (int)Math.Pow(QuadricSequenceNum(n - 1), 2) + (int)Math.Pow(QuadricSequenceNum(n - 2), 2);
            }
        }

        public static int QuadricSequenceSumToN(int n) // 13 b
        {
            if (n <= 0)
            {
                return 0;
            } return QuadricSequenceNum(n) + QuadricSequenceSumToN(n-1);
        }

        public static int RecursiveMax(int[] arr, int i = 0) // N
        {
            if (i == arr.Length-1)
            {
                return arr[i];
            }

            return Math.Max(arr[i], RecursiveMax(arr, i+1));
        }

        public static int SumArrToI(int[] arr, int i) // 14
        {
            if (i < 0)
            {
                return 0;
            }

            if (i == 0)
            {
                return arr[0];
            }

            return arr[i] + SumArrToI(arr, i-1);
        }

        public static int PosCountArrToN(int[] arr, int n) // 15
        {
            if (n == 0)
            {
                return arr[n] >= 0 ? 1 : 0;
            }

            return (arr[n] >= 0 ? 1 : 0) + PosCountArrToN(arr, n - 1);
        }

        public static int FindInArr(int[] arr, int n, int i = 0) // 16
        {
            if (i == arr.Length)
            {
                return -1;
            }

            if (arr[i] == n)
            {
                return i;
            }
            else
            {
                return FindInArr(arr, n, i + 1);
            }
        }

        public static bool IsSorted(int[] arr, int i = 0) // 17
        {
            if (i == arr.Length - 2)
            {
                return arr[i] < arr[i + 1];
            }

            return arr[i] < arr[i+1] && IsSorted(arr, i + 1);
        }

        public static bool HasPrimes(int[] arr, int i = 0) // 18
        {
            if (i == arr.Length - 1)
            {
                return !IsPrimeRecursive(arr[i]);
            }

            if (!IsPrimeRecursive(arr[i]))
            {
                return HasPrimes(arr, i + 1);
            }
            else
            {
                return false;
            }
        }

        public static int AppearsInLine(int[,] arr, int n, int i = 0) // 19
        {
            if (i == arr.GetLength(0))
            {
                return 0;
            }

            bool isInArr = false;

            for (int j = 0; j < arr.GetLength(1) && !isInArr; j++)
            {
                if (arr[i,j] == n)
                {
                    isInArr = true;
                }
            }

            if (isInArr)
            {
                return 1 + AppearsInLine(arr, n, i + 1);
            }
            else
            {
                return AppearsInLine(arr, n, i + 1);
            }
        }

    }
}
