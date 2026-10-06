using Prjcts;
using System.ComponentModel;

namespace Prjcts
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public static void Test1()
        {
            IntNode n1 = new IntNode(-17);
            IntNode n = new IntNode(17, n1);
        }

        public static void Menu()
        {
            bool repeatChoosing = false;

            do
            {
                repeatChoosing = false;

                Console.Write("Choose what task you want to test:\n");
                Console.WriteLine("\n0 - Exit\n");
                Console.Write("Choose: ");
                Console.WriteLine();

                switch (Console.ReadKey().KeyChar)
                {
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There's no task under this number/symbol! Try again");
                        break;
                }

            } while (Funcs.RepeatChoosing());
        }
    }
}
