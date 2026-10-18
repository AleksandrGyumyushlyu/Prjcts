using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    internal class StringPractice
    {
        public static void unitTest()
        {
            string choice;
            bool keep = false;
            int count;
            string message1, message2;
            char tav;
            do
            {
                Console.WriteLine("Tasks:\n0, 1, 2, 3, 4, 5, 6a, 6b, 7\n8, 9, 10, 11, 12, 13, 14, 15");
                Console.Write("Choose task  you want to test: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        count = StringPractice.wordCount(message1);
                        Console.WriteLine(count);
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "1":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a char: ");
                        tav = char.Parse(Console.ReadLine());
                        Console.WriteLine(StringPractice.matchingChar(message1, tav));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "2":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a message: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.matchingLength(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "3":
                        Console.Write("Enter a new password: ");
                        message1 = Console.ReadLine();
                        Console.Write("Confirm a new password: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.matchingStrings(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "4":
                        Console.Write("Enter your name: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter name who you writing to: ");
                        message2 = Console.ReadLine();
                        Console.Write(StringPractice.sendingLetter(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "5":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        message1 = StringPractice.reverseWords(message1);
                        Console.WriteLine(message1);
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "6a":
                        Console.Write("Enter a lowkey letter: ");
                        tav = char.Parse(Console.ReadLine());
                        tav = StringPractice.capsLock(tav);
                        Console.WriteLine(tav);
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "6b":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        message1 = StringPractice.ultraCapsLock(message1);
                        Console.WriteLine(message1);
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "7":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a letter: ");
                        tav = char.Parse(Console.ReadLine());
                        count = StringPractice.letterAmountFinder(message1, tav);
                        Console.WriteLine($"Letter found in text: {count} times");
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "8":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a letter: ");
                        tav = char.Parse(Console.ReadLine());
                        count = StringPractice.placeInString(message1, tav);
                        Console.WriteLine($"Letter first place index in text is {count}");
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "9":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a message: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.findInStart(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "10":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a message: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.findInEnd(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "11":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a number: ");
                        count = int.Parse(Console.ReadLine());
                        Console.WriteLine(StringPractice.shortenedToString(message1, count));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "12":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a number: ");
                        count = int.Parse(Console.ReadLine());
                        Console.WriteLine(StringPractice.shortenedFromString(message1, count));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "13":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a message: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.findInString(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "14": // zyxwvutsrqponmlkjihgfhihgfedcddacba 
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a message: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.dictionaryOrder(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "15":
                        Console.Write("Enter a message: ");
                        message1 = Console.ReadLine();
                        Console.Write("Enter a message: ");
                        message2 = Console.ReadLine();
                        Console.WriteLine(StringPractice.ternaryDictionary(message1, message2));
                        keep = Funcs.RepeatChoosing();
                        break;
                    case "16":
                        Console.WriteLine("Ido was here");
                        keep = Funcs.RepeatChoosing();
                        break;
                    default:
                        Console.WriteLine("There is no exercise under this number");
                        keep = Funcs.RepeatChoosing();
                        break;

                }
            } while (keep);


        }
        public static int wordCount(string S)
        {

            int count = 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 32)
                    count++;
            }

            return count;
        }

        public static bool matchingChar(string S, char t)
        {
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == t)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool matchingLength(string S1, string S2)
        {
            if (S1.Length == S2.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool matchingStrings(string S1, string S2)
        {
            if (!StringPractice.matchingLength(S1, S2))
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Math.Max(S1.Length, S2.Length); i++)
                {
                    if (S1[i] != S2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        public static string sendingLetter(string senderName, string targetName)
        {
            Console.WriteLine("Write a letter:");
            Console.WriteLine("======================================================");
            string letterBody = Console.ReadLine();
            string letter = $"Dear {targetName},\n{letterBody}\n\nBest regard,\n{senderName}";
            return letter;

        }

        public static string reverseWords(string S1)
        {
            string S2 = "";
            for (int i = S1.Length - 1; i >= 0; i--)
            {
                S2 += S1[i];
            }
            return S2;
        }

        public static char capsLock(char letter)
        {
            int dif = 'a' - 'A';
            if (!(letter >= 'a' && letter <= 'z'))
            {
                return letter;
            }
            else
            {
                return (char)(letter - dif);
            }

        }

        public static string ultraCapsLock(string S)
        {
            string S2 = "";
            for (int i = 0; i < S.Length; i++)
            {
                S2 += capsLock(S[i]);
            }
            return S2;
        }

        public static int letterAmountFinder(string S, char T)
        {
            int letterCounter = 0, otherCaseT = 0, dif = 'a' - 'A';

            for (int i = 0; i < S.Length; i++)
            {

                if (T <= 'z' && T >= 'a')
                {
                    otherCaseT = T - dif;
                }
                else if (T <= 'Z' && T >= 'A')
                {
                    otherCaseT = T + dif;
                }
                if (S[i] == T || S[i] == otherCaseT)
                {
                    letterCounter++;
                }
            }
            return letterCounter;
        }

        public static int placeInString(string S, char T)
        {
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == T)
                {
                    return i;
                }
            }

            return -1;
        }

        public static bool findInStart(string S1, string S2)
        {
            int matchingCount = 0;
            for (int i = 0; i < S2.Length; i++)
            {
                if (S1[i] != S2[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool findInEnd(string S1, string S2)
        { 
            for (int i = S1.Length - S2.Length, j = 0; i < S1.Length; i++, j++)
            {
                if (S1[i] != S2[j])
                {
                    return false;
                }
            }

            return true;
        }

        public static string shortenedToString(string S, int k)
        {
            string newString = "";

            if (k > S.Length - 1 || k < 0)
            {
                return " ";
            }

            for (int i = 0; i < k; i++)
            {
                newString += S[i];
            }

            return newString;
        }

        public static string shortenedFromString(string S, int k)
        {
            string newString = "";

            if (k > S.Length - 1 || k < 0)
            {
                return " ";
            }

            for (int i = k-1; i < S.Length; i++)
            {
                newString += S[i];
            }

            return newString;
        }

        public static bool findInString(string S1, string S2)
        {
            for (int i = 0; i < S1.Length; i++)
            {
                for (int j = 0; j < S2.Length; j++)
                {
                    if (S1[i] == S2[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
        public static string alphabetOrder(string S1, string S2)
        { 
            string inOrder = "";
            
            if (S1.Length > S2.Length)
            {
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < S1.Length; j++)
                    {
                        if (S1[j] == 'a' + i || S1[j] == 'A' + i)
                        {
                            inOrder += S1[j];
                        }
                    }

                }
                return inOrder;
            }

            else
            {
                for (int i = 0; i < 26; i++)
                {
                    for (int j = 0; j < S2.Length; j++)
                    {
                        if (S2[j] == 'a' + i || S2[j] == 'A' + i)
                        {
                            inOrder += S2[j];
                        }
                    }

                }
                return inOrder;
            }
        }


        public static string dictionaryOrder(string S1, string S2)
        {
            string S1CAPS = StringPractice.ultraCapsLock(S1);
            string S2CAPS = StringPractice.ultraCapsLock(S2);

            for (int i = 0; i < Math.Min(S1.Length, S2.Length); i++)
            {
                if (S1[i] < S2[i])
                {
                    return S1;
                }
                else if (S1[i] > S2[i])
                {
                    return S2;
                }
            }

            return (S1.Length < S2.Length) ? S1 : S2;

        }

        public static int ternaryDictionary(string S1, string S2)
        {
            if (StringPractice.matchingStrings(S1, S2))
            {
                return 0;
            }

            else if (StringPractice.matchingStrings(StringPractice.dictionaryOrder(S1, S2), S1))
            {
                return 1;
            }

            else
            {
                return -1;
            }
        }

    }
}
