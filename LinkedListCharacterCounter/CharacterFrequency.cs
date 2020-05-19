using System;

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
            Character = aChar;
            Frequency = 0;
        }
        public CharacterFrequency(char aChar, long charCount)
        {
            Character = aChar;
            Frequency = charCount;
        }

        public void IncrementFrequency()
        {
            _freq++;
        }

        public override bool Equals(object aChar)
        {
            bool equal = false;
            CharacterFrequency frequency = new CharacterFrequency((char)aChar);
            frequency = (CharacterFrequency) aChar;
            if (this.Character == frequency.Character) equal = true;
            return equal;
        }

        public override string ToString()
        {
            string output = String.Format(_char + " " + "(" + (byte) _char + ")" + "\t" + " = " + _freq);
            return output;
        }
    }
}
