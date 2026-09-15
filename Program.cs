using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program.Menu1(); // Do the 1 to 23
            // Program.ClassTests(); // not related
            Program.Menu2(); // Do the 24 - 34 + etgars
        }

        static void Menu1()
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
                Console.Write("7 - Task 7\n8 - Task 8\n9 - Task\nA - Task 10\nB - Task 11\nC - Task 12\nd - Task 13 paragraph a\nD - Task 13 paragraph b\nE - Task 14\n");
                Console.WriteLine("F - Task 15\nG - Task 16\n");
                Console.WriteLine("\n0 - Exit\n");
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
                    case 'C':
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
                    case 'd':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.QuadricSequenceNum(n));
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
                    case 'D':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.QuadricSequenceSumToN(n));
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
                    case 'E':
                    case 'e':
                        Console.WriteLine();
                        
                        int[] testArr = Funcs.GenArr(10, 0, 100);
                        Funcs.PrintArray(testArr);
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.SumArrToI(testArr, n-1));
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
                    case 'F':
                    case 'f':
                        Console.WriteLine();
                        
                        int[] testArr1 = Funcs.GenArr(10, -50, 50);
                        Funcs.PrintArray(testArr1);
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            if (n >= 0)
                            {
                                Console.WriteLine(Recursion.PosCountArrToN(testArr1, n));
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
                    case 'G':
                    case 'g':
                        Console.WriteLine();
                        
                        int[] testArr2 = Funcs.GenArr(10, -50, 50);
                        Funcs.PrintArray(testArr2);
                        Console.WriteLine("Enter any integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            Console.WriteLine(Recursion.FindInArr(testArr2, n));
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case 'H':
                    case 'h':
                        Console.WriteLine();
                        int[] testArr3 = [0, 1, 2, 4, 5, 7, 4];
                        Console.WriteLine(Recursion.IsSorted(testArr3));
                        break;
                    case 'i':
                    case 'I':
                        int[] testArr4 = Funcs.GenArr(10, 0, 100);
                        Funcs.PrintArray(testArr4);
                        Console.WriteLine(Recursion.HasPrimes(testArr4));
                        break;
                    case 'j':
                    case 'J':
                        Console.WriteLine();
                        int[,] testArr5 = {{39, 94, 85, 21, 76}, {39, 231, 21, 39, 59}};
                        
                        Console.WriteLine("Enter any integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            Console.WriteLine(Recursion.AppearsInLines(testArr5, n));
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
                        break;
                    case 'k':
                    case 'K':
                        Console.WriteLine();
                        int[] testArr6 = {0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0};
                        Funcs.PrintArray(testArr6); Console.WriteLine();

                        Console.WriteLine("\n" + Recursion.RandomPalindrome(testArr6));
                        break;
                    case 'l':
                    case 'L':
                        Console.WriteLine();
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        
                        Console.WriteLine(Recursion.LowkeyAbc(input));
                        break;
                    case 'M':
                    case 'm':
                        Console.WriteLine();
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        
                        Console.WriteLine(Recursion.AddStars(input));
                        break;
                    case 'n':
                    case 'N':
                        Console.WriteLine();
                        Console.WriteLine("Enter a string: ");
                        input = Console.ReadLine();
                        
                        Console.WriteLine(Recursion.ReverseStr(input));
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There's no task under this number/symbol! Try again");
                        break;
                }

            } while (Funcs.RepeatChoosing());
        }

        public static void ClassTests()
        {
            int[] arr = [12, 123, 12, 58];

            Console.WriteLine(Recursion.RecursiveMax(arr));
        }

        public static void Menu2()
        {
            bool repeatChoosing = false;
            char lt1;
            char lt2;

            do
            {
                repeatChoosing = false;
                string input;
                int n;

                Console.Write("Choose what task you want to test:\n1 - 11 (24-34)");
                Console.WriteLine("\n0 - Exit\n");
                Console.Write("Choose: ");
                Console.WriteLine();

                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        Console.WriteLine("Enter 2 lower case letters: ");
                        lt1 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (EngUtils.IsLowerCase(lt1))
                        {
                            Console.WriteLine("Enter second letter: ");
                            lt2 = Console.ReadKey().KeyChar;
                            Console.WriteLine();

                            VoidRecursion.PrintBetweenLetters(lt1, lt2);
                        }
                        else
                        {
                            Console.WriteLine("Not a lower case letter, try again");
                        }
                        break;
                    case '2':
                        Console.WriteLine();
                        Console.WriteLine("Enter any positive integer number: ");
                        input = Console.ReadLine();
                        if (Funcs.IsInt(input))
                        {
                            n = int.Parse(input);
                            VoidRecursion.PrintMultiples(n);
                        }
                        else
                        {
                            Console.WriteLine("The input isn't an integer! Try again");
                        }
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
