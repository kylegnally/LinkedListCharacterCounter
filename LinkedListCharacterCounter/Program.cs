using System;
using System.IO;
using System.Collections.Generic;

namespace LinkedListCharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
#if DEBUG
            args = new[] { "testfile.txt" };
#endif

            if (args.Length > 1)
            {
                Console.WriteLine("File writing is unsupported.");
                Environment.Exit(0);
            }
            else HandleFile(ReadFile(args));

        }

        private static char[] ReadFile(string[] args)
        {
            char[] chars = null;
            if (args != null)
            {
                if (File.Exists(args[0]))
                {
                    try
                    {
                        string fullPath = Environment.CurrentDirectory + "\\" + args[0];
                        using (StreamReader reader = new StreamReader(fullPath))
                        {
                            char[] contents = reader.ReadToEnd().ToCharArray();
                            return contents;
                        }
                    }
                    catch
                    {
                        throw new FileLoadException();
                    }
                }
                throw new FileNotFoundException();
            }
            throw new NullReferenceException();
        }

        private static void HandleFile(char[] chars)
        {
            LinkedList<CharacterFrequency> frequencyList = new LinkedList<CharacterFrequency>();
            CharacterFrequency aCharacterInlist = new CharacterFrequency(chars[0]);

            // foreach on my char array
                // foreach on the linked list
                    //equality test
                        //if true, increment freq

            foreach (char aCharacter in chars)
            {
                foreach (CharacterFrequency frequency in frequencyList)
                {
                    if ( /* the character we're evaluating equals the one in the linked list */ )
                    {
                        // increment the frequency of that character
                    }
                }
            }

            //String str = "picture perfect";
            //int[] freq = new int[str.Length];
            //int i, j;

            ////Converts given string into character array  
            //char[] string1 = str.ToCharArray();

            //for (i = 0; i < str.Length; i++)
            //{
            //    freq[i] = 1;
            //    for (j = i + 1; j < str.Length; j++)
            //    {
            //        if (string1[i] == string1[j])
            //        {
            //            freq[i]++;

            //            //Set string1[j] to 0 to avoid printing visited character  
            //            string1[j] = '0';
            //        }
            //    }
            //}
            //CharacterFrequency[] allCharsAsObj = new CharacterFrequency[chars.Length];
            //int outer, inner;   // name the loops so I don't get lost
            //for (outer = 0; outer < chars.Length; outer++)
            //{
            //    allCharsAsObj[outer].Frequency = 1;
            //    for (inner = outer + 1; outer < chars.Length; outer++)
            //    {
            //        if (chars[outer] == chars[inner])
            //        {
            //            allCharsAsObj[outer].Frequency++;
            //            chars[inner] = '0';
            //        }
            //    }
            //}

            //foreach (CharacterFrequency character in allCharsAsObj)
            //{
            //    Console.WriteLine("Character " + character.Character + " appears " + character.Frequency + " times in the array.");
            //}
            //Console.WriteLine("Have a day!");
        }
    }
}
