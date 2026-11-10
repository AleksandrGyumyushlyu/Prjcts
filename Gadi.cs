using Prjcts;
using System.ComponentModel;

public class Gadi
{
    public static void UnCrashable()
    {
        int[] grades = new int[2];
        string[] input = new string[2];

        Console.Write("Enter grade 1: ");
        input[0] = Console.ReadLine();
        Console.Write("Enter grade 2: ");
        input[1] = Console.ReadLine();

        try
        {
            grades[0] = int.Parse(input[0]);
            grades[1] = int.Parse(input[1]);
        }
        catch (FormatException)
        {
            Console.WriteLine("One of the grades isn't number.");
        }

        Console.WriteLine($"Avg: {(grades[0] + grades[1]) / 2}");
    }

    static void LongProcess()
    {
        Console.WriteLine("Long Process Started");
        int x = 0;
        for (int i = 0; i < 50000; i++)
        {
            for (int j = 0; j < 100000; j++)
            {
                x = x + i;
            }
        }
        Console.WriteLine(x);
        Console.WriteLine("Long Process Completed");
    }
    static void ShortProcess()
    {
        Console.WriteLine("Short Process Started");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
        Console.WriteLine("Short Process Completed");
    }

    static void printRed()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(i + " ");
        }
    }
    static void printGreen()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(i + " ");
        }
    }

    static void printColor(ConsoleColor color)
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.ForegroundColor = color;
            Console.Write(i + " ");
        }
    }

    public static void printHelper1()
    {
        printColor(ConsoleColor.Blue);
    }

    public static void printHelper2()
    {
        printColor(ConsoleColor.White);
    }

    public static void LongShort()
    {
        // Task.Run(LongProcess);
        // Task.Run(ShortProcess);
        // Console.ReadKey();
        // Task.Run(printRed);
        // Task.Run(printGreen);
        Task.Run(() => printColor(ConsoleColor.Blue));
        Task.Run(() => printColor(ConsoleColor.White));
        Console.ReadKey();
    }
}
