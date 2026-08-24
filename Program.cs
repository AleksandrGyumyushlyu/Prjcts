using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeatChoosing = false;
            int n;
            string input;

            do
            {
                repeatChoosing = false;

                Console.Write("Choose what task you want to test:\n1 - Task 1\n2 - Task 2\n3 - Task 3\n4 - Task 4\n5 - Task 5\n6 - Task 6\n");
                Console.Write("7 - Task 7\n8 - Task 8\n9 - Task\nA - Task 10\nB - Task 11\nC - Task 12\nD - Task 13\n0 - Exit\n");
                Console.Write("Choose: ");

                switch (Console.ReadKey().KeyChar)
                {
                    case '0':
                        Console.WriteLine();
                        Console.Write("Closed");
                        break;
                    case '1':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.SumToNRecursive(n));
                            }
                            else
                            {
                                Console.WriteLine("The number isn't positive! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case '2':
                        break;
                    case '3':
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There's no task under this symbol/number! Try again");
                        break;
                }

            } while (Funcs.RepeatChoosing());
        }
    }
}
