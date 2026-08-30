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
            int n2;
            string input;
            string input2;

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
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.NFactorialRecursive(n));
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
                    case '3':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.NOddFactorialRecursive(n));
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
                    case '4':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.DigitCountRecursive(n));
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
                    case '5':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            Console.WriteLine("Enter any positive integer number: ");
                            input2 = Console.ReadLine();
                            if (Funcs.IsInt(input2))
                            {
                                n2 = int.Parse(input2);
                                Console.WriteLine(Recursion.RawRecursiveDivision(n, n2));
                            }
                            else
                            {
                                Console.WriteLine("The input isn't an integer! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case '6':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            Console.WriteLine("Enter any positive integer number: ");
                            input2 = Console.ReadLine();
                            if (Funcs.IsInt(input2))
                            {
                                n2 = int.Parse(input2);
                                Console.WriteLine(Recursion.RecursiveModulo(n, n2));
                            }
                            else
                            {
                                Console.WriteLine("The input isn't an integer! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case '7':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            Console.WriteLine("Enter any positive integer number: ");
                            input2 = Console.ReadLine();
                            if (Funcs.IsInt(input2))
                            {
                                n2 = int.Parse(input2);
                                Console.WriteLine(Recursion.IsMultiple(n, n2));
                            }
                            else
                            {
                                Console.WriteLine("The input isn't an integer! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case '8':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.IsPrimeRecursive(n));
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
                    case '9':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.NeverOddOrEven(n));
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
                    case 'a':
                    case 'A':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.MultipliedByToUpToN(n));
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
                    case 'b':
                    case 'B':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.ChainToN(n));
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
                    case 'c':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            Console.WriteLine("Enter any positive integer number: ");
                            input2 = Console.ReadLine();
                            if (Funcs.IsInt(input2))
                            {
                                n2 = int.Parse(input2);
                                Console.WriteLine(Recursion.MultiplesUpToN2(n, n2));
                            }
                            else
                            {
                                Console.WriteLine("The input isn't an integer! Try again");
                            }
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case 'C':
                        break;
                    case 'd':
                    case 'D':
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There's no task under this number/symbol! Try again");
                        break;
                }

            } while (Funcs.RepeatChoosing());
        }
    }
}
