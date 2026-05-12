using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
using Prjcts;

namespace Prjcts
{
    internal class TwoDimArrs
    {
        public static void UnitTest()
        {
            // int[,] grd = new int[19, 4];
            // Matrix.RandomGrades(grd);
            // Console.WriteLine("-------------------------------");
            // Matrix.Print(grd);
            // Console.WriteLine("-------------------------------");
            // Console.WriteLine(Matrix.Avrg(grd));
            // Console.WriteLine("-------------------------------");
            // Console.WriteLine("Row student #3 avrg is: " + Matrix.RowAvrg(grd,2));
            // Console.WriteLine("-------------------------------");
            // Console.WriteLine("Col Test #2 avrg is: " + Matrix.RowAvrg(grd, 1));
            Console.WriteLine("SMH");
        }

        public static void RandomGrades(int[,] studentsGrades)
        {
            Random rnd = new Random();
            for (int row = 0; row < studentsGrades.GetLength(0); row++)
            {
                for (int col = 0; col < studentsGrades.GetLength(1); col++)
                {
                    studentsGrades[row, col] = rnd.Next(55, 101);
                }
            }
        }

        public static double Avrg(int[,] grades)
        {
            int sum = 0;
            for (int row = 0; row < grades.GetLength(0); row++)
            {
                for (int col = 0; col < grades.GetLength(1); col++)
                {
                    sum += grades[row, col];
                }
            }

            return (double)(sum / grades.Length);
        }

        public static double StudentAvrg(int[,] studentsGrades, int student)
        {
            int sum = 0;
            for (int col = 0; col < studentsGrades.GetLength(1); col++)
            {
                sum += studentsGrades[student, col];
            }

            return (double)(sum / studentsGrades.GetLength(1));
        }

        public static double ExamAvrg(int[,] studentsGrades, int exam)
        {
            int sum = 0;
            for (int row = 0; row < studentsGrades.GetLength(0); row++)
            {
                sum += studentsGrades[row, exam];
            }

            return (double)(sum / studentsGrades.GetLength(0));
        }
    }
}
