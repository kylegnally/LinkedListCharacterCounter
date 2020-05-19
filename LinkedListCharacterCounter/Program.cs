using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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

            // foreach on my char array
                // foreach on the linked list
                    //equality test
                        //if true, increment freq

            foreach (char aCharacter in chars)
            {
                CharacterFrequency cf = new CharacterFrequency(aCharacter);
                frequencyList.AddLast(cf);
                foreach (CharacterFrequency freq in frequencyList)
                {
                    // if the character is equal to aCharacter
                    if (freq.Character.Equals(aCharacter))
                    {
                        freq.IncrementFrequency();
                    }
                }
            }
            Console.WriteLine("loop complete.");
        }
    }
}
