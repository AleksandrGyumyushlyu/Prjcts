using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Program
    {
        static void InheritanceLauncher()
        {
            bool repeatChoosing = false;

            do
            {
                repeatChoosing = false;

                Console.Write("Choose what you want to test:\n1 - Checking Account system\n2 - Saving account system\n3 - Employee class\n4 - Business Account\n5 - Bank Services\n6 - Sort Services\n");
                Console.Write("0 - Close\n");
                Console.Write("Choose: ");

                switch (Console.ReadKey().KeyChar)
                {
                    case '0':
                        Console.WriteLine();
                        Console.Write("Closed");
                        break;
                    case '1':
                        Console.WriteLine();
                        CheckingAccount.UnitTest();
                        break;
                    case '2':
                        Console.WriteLine();
                        SavingAccount.UnitTest();
                        break;
                    case '3':
                        Console.WriteLine();
                        Employee.UnitTest();
                        break;
                    case '4':
                        Console.WriteLine();
                        BusinessAccount.UnitTest();
                        break;
                    case '5':
                        Console.WriteLine();
                        BankServices.UnitTest();
                        break;
                    case '6':
                        Console.WriteLine();
                        SortServices.UnitTest();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Error");
                        break;
                }

            } while (Funcs.RepeatChoosing());
        }

        static void Main(string[] args)
        {
            // InheritanceLauncher();
            StackPractice.Launcher();
        }
    }
}
