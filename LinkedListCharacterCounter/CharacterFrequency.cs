using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCharacterCounter
{
    class CharacterFrequency
    {
        private char _char;
        private int _freq;

        public char Character { get; set; }
        public long Frequency { get; set; }

        public CharacterFrequency(char aChar)
        {
        }

        public void IncrementFrequency()
        {
            _freq++;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);    
        }

        public override string ToString()
        {
            string output = String.Format(_char + " " + "(" + (byte) _char + ")" + "\t" + " = " + _freq);
            return output;
        }
    }
}
