using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class VoidRecursion
    {
        public static void PrintBetweenLetters(char lt1, char lt2)
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

        private static void PrintMultiples(int n, int i)
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

    }
}
