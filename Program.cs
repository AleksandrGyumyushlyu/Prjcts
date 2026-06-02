using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeatChoosing = false;

            do
            {
                repeatChoosing = false;

                Console.Write("Choose what you want to test:\n1 - Checking Account system\n2 - Saving account system\n3 - Basic Account\n4 - Employee class\n0 - Close\nChoose: ");

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
                        BasicAccount.UnitTest();
                        break;
                    case '4':
                        Console.WriteLine();
                        Employee.UnitTest();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Error");
                        repeatChoosing = Funcs.RepeatChoosing();
                        break;
                }

            } while (repeatChoosing);
        }
    }
}
