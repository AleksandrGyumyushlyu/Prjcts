using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Recursion
    {
        public static int SumToNRecursive(int n)
        {
            if (n <= 0)
            {
                return n;
            }

            return n + SumToNRecursive(n-1);
        }
    }
}
