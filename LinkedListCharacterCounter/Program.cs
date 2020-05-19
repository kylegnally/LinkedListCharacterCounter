using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach (char aCharacter in chars)
            {
                if (frequencyList.First == null) frequencyList.AddFirst(aCharacter.)
            }
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
