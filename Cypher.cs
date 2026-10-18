using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prjcts
{
    internal class Cypher // (Asiti comments lefi conventsiot)
    {

        /*
        UnitTest to Caesar functions:
        Records user choice of what function user wants to use and proceeds using it 
        input: none
        output: none
        */
        public static void unitTest()
        {
            bool keepLooping = false;
            string choice, cypherChoice, message;
            int key;

            do
            {
                Console.Write("1 - Caesar cypher\n2 - Scrambling pair encryption\nEnter what do you want to do: "); // Showing options to user + query for input
                choice = Console.ReadLine(); // Input of the choice
                switch (choice)
                {
                    case "1": // Caesar cypher
                        Console.Write("1 - Encrypt\n2 - Decrypt\n3 - Find the key for the cypher\nEnter what do you want to do: ");  // Showing options to user + query for input
                        cypherChoice = Console.ReadLine(); // Input of the choice
                        switch (cypherChoice)
                        {
                            case "1": // Encrypt Caesar
                                Console.Write("Enter a message you want to encrypt: "); // Query for string
                                message = Console.ReadLine(); // Input of string
                                Console.Write("Enter how many letters you want to move in the cypher: "); // Query for integer
                                key = int.Parse(Console.ReadLine()); // input of integer
                                message = Cypher.caesarCypher(message, key); // Calling for Caesar encrypting function
                                Console.WriteLine($"Your encrypted message: {message}"); // Printing result of encryption
                                break;
                            case "2": // Decrypt Caesar
                                Console.Write("Enter a message you want to decrypt: "); // Query for string
                                message = Console.ReadLine(); // Input of string
                                Console.Write("Enter key for the cypher: ");  // Query for integer
                                key = int.Parse(Console.ReadLine()); // input of integer
                                message = Cypher.caesarDecypher(message, key); // Calling for Caesar decrypting function
                                Console.WriteLine($"Your decrypted message: {message}"); // Printing result of decryption
                                break;
                            case "3": // Find out Caesar
                                Console.Write("Enter a message you want to decrypt: "); // Query for string
                                message = Console.ReadLine(); // Input of string
                                key = Cypher.caesarKeyFinder(message); // Calling for caesar key finder function to find out the key
                                message = Cypher.caesarDecypher(message, key); // Calling for Caesar decrypting function
                                Console.WriteLine($"Your decrypted message: {message} \nKey for the cypher is: {key}"); // Printing result of decryption and key to the cypher
                                break;
                            default:
                                Console.WriteLine("There is no such an option");
                                break;

                        }
                        keepLooping = Funcs.RepeatChoosing(); // Ask whether to keep operating
                        break;
                    case "2": // Scrambling pair cypher
                        Console.Write("Enter a message you want to encrypt or decrypt: ");  // Query for string
                          message = Console.ReadLine(); // Input of string 
                        message = scrambleText(message); // Call for scrambling pairs encryption function
                        Console.WriteLine($"Your encrypted message: {message}"); // Printing result of encryption
                        keepLooping = Funcs.RepeatChoosing(); // Ask whether to keep operating
                        break;
                    default:
                        Console.WriteLine("There is no such an option");
                        keepLooping = Funcs.RepeatChoosing(); // Ask whether to keep operating
                        break;
                }
            } while (keepLooping);
        }

        /*
        This function cyphers message encrypted with the Caesar cypher based on the key you input
        input: string (message) and integer num (key to the cypher)
        output: string (encrypted message)
        */
        public static string caesarCypher(string str, int key) 
        {
            string newStr = "";
            key %= 26;
            for (int i = 0; i < str.Length; i++)
            {
                if (EngUtils.isLowerCase(str[i]))
                { 
                    if (str[i] + key > 'z')
                    { 
                        newStr += (char)('a'-1 + (key - ('z' - str[i])));
                    }
                    else if (str[i] + key < 'a') 
                    {
                        newStr += (char)('z'+1 + (key - ('a' - str[i])));
                    }
                    else 
                    {
                        newStr += (char)(str[i] + key);
                    }
                }

                else if (EngUtils.isUpperCase(str[i]))
                {
                    if (str[i] + key > 'Z')
                    {
                        newStr += (char)('A'-1 + (key - ('Z' - str[i])));
                    }
                    else if (str[i] + key < 'A')
                    {
                        newStr += (char)('Z'+1 + (key - ('A' - str[i])));
                    }
                    else
                    {
                        newStr += (char)(str[i] + key);
                    }
                }

                else
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }


        /*
        This function decyphers message encrypted with the Caesar cypher based on the key you input
        input: string (message) and integer num (key to the cypher)
        output: string (decrypted message)
        */
        
        public static string caesarDecypher(string str, int key)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr = Cypher.caesarCypher(str, -key);
            }
            return newStr;

        }

        /*
        This function checks up to 26 to Caesar cypher, if found returns the key 
        (Only 26 because if you move 27 letters, it doesn't move lol, its like A to A or J to J, there is no point)
        input: string
        output: integer number (key to the Caesar cypher)
        */
        public static int caesarKeyFinder(string str)
        {
            int key = 0, rightKey = 0;
            double percentage, maxPercentage = 0;
            while (key < 26)
            {
                key++;
                percentage = EngUtils.getEnglishWordPercentage(caesarDecypher(str, key));
                if (percentage > maxPercentage)
                {
                    maxPercentage = percentage;
                    rightKey = key;
                }
                
            }

            return rightKey;
        }

        /*
        This function replaces each pair of characters in string one with each other / Scrambled pairs cypher (There is no difference between encryption and decryption)
        input: string
        output: string
        */
        public static string scrambleText(string str)
        {
            string newStr = "";
            for (int i = 0; (str.Length % 2 == 0) ? i < str.Length : i < str.Length-1; i++) // Sneaky ternary operator: if amount of characters in string is even then loop with operate
            {  // untill the all characters are replaced, if amount of characters is odd then it will operate untill i is smaller than length of a string without last character
                if (i % 2 == 0 || i == 0)
                {
                    newStr += str[i + 1];
                }
                        else if (i % 2 != 0)
                {
                    newStr += str[i - 1];
                }
            }
            if (str.Length % 2 != 0)
            {
                newStr += str[str.Length - 1];
            }
            return newStr;
        }

        /*
        This function detects if message is encrypted or no
        input: string 
        output: true / false value
        */
        public static bool isEncrypted(string str)
        {
            if (EngUtils.getEnglishWordPercentage(str) >= 70)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        

    }
}
