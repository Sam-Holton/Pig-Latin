using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueTranslation = true;
            while (continueTranslation)
            {
                Console.Write("Welcome to the Pig Latin Translator.\nPlease enter a word: ");
                string userInput = Console.ReadLine();

                string finalString = null;

                // Remove whitespace from beginning and end of word
                string trimmedString = userInput.Trim();

                // Convert word into all lower case characters
                trimmedString = trimmedString.ToLower();

                //Setting vowelIndex to out of range number in case there aren't any vowels in the string
                int vowelIndex = -1;

                //Finds the index of the first vowel in the string
                for (int i = 0; i < trimmedString.Length - 1; i++) 
                {
                    switch (trimmedString[i])
                    {
                        case 'a':
                            vowelIndex = i;
                            break;
                        case 'e':
                            vowelIndex = i;
                            break;
                        case 'i':
                            vowelIndex = i;
                            break;
                        case 'o':
                            vowelIndex = i;
                            break;
                        case 'u':
                            vowelIndex = i;
                            break;
                        default: continue;
                    }
                    if (vowelIndex > -1)
                    {
                        break;
                    }
                }

                // Rewrites word in Pig Latin
                if (vowelIndex == -1)
                {
                    trimmedString = trimmedString + "ay";
                }
                else if (vowelIndex == 0)
                {
                    trimmedString = trimmedString + "way";
                }
                else
                {
                    // Credit to Candace Goodson for pointing us towards using .Substring to reorganize original string
                    // finalString = trimmedString.Substring(vowelIndex, trimmedString.Length - 1) + trimmedString.Substring(0, vowelIndex - 1) + "ay";
                    Console.WriteLine(trimmedString.Substring(vowelIndex, trimmedString.Length - 1));
                    Console.WriteLine(trimmedString.Substring(0, vowelIndex - 1));
                }

                Console.WriteLine(finalString);

                do
                {
                    Console.Write("Would you like to continue (Y/N)? ");
                    ConsoleKey inputKey = Console.ReadKey().Key;

                    if (inputKey == ConsoleKey.Y)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (inputKey == ConsoleKey.N)
                    {
                        continueTranslation = false;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input. Please try again.");                                              
                    }
                } while (true);
            }
        }
    }
}