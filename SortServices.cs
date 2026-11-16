using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class SortServices
    {
        public static void QuickSort(IComparable[] arr) // Credits to BroCode: https://www.youtube.com/watch?v=Vtckgz38QHs
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        private static void QuickSort(IComparable[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int pivot = partition(arr, start, end);

            QuickSort(arr, start, pivot - 1);
            QuickSort(arr, pivot + 1, end);
        }

        private static int partition(IComparable[] arr, int start, int end)
        {
            int i = start - 1;

            for (int j = start; j < end; j++)
            {
                if (arr[j].CompareTo(arr[end]) < 0) // If arr[j] < arr[pivot]
                {
                    i++;
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                }
            }

            i++;
            (arr[end], arr[i]) = (arr[i], arr[end]);

            return i;
        }

        public static void UnitTest()
        {
            BankServices sortTest = new BankServices(7, true);
            IComparable[] sortArray = new IComparable[sortTest.GetLastFreeIndex()];
            int index = 0;

            foreach (BasicAccount account in sortTest.GetAccounts())
            {
                if (account is CheckingAccount)
                {
                    sortArray[index] = (IComparable)account;
                    index++;
                }
            }
            index = 0;

            Console.WriteLine("Before Sort");
            for (int i = 0; i < sortArray.Length; i++)
            {
                if (sortArray[i] != null)
                {
                    Console.WriteLine(sortArray[i].ToString());
                }
            }

            QuickSort(sortArray);

            Console.WriteLine("After Sort");

            for (int i = 0; i < sortArray.Length; i++)
            {
                if (sortArray[i] != null)
                {
                    Console.WriteLine(sortArray[i].ToString());
                }
            }
        }
    }
}
