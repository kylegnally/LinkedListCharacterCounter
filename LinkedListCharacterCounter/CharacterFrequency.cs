using System;

namespace LinkedListCharacterCounter
{
    class CharacterFrequency
    {
        private char _char;
        private int _freq;

        public char Character
        {
            get
            {
                return _char;
            }
            set
            {
                if (value != null) _char = value;
            }
        }

        public long Frequency
        {
            get
            {
                return _freq;
            }
            set
            {
                if (value < 0) value = 0;
            }
        }

        //public CharacterFrequency() { }

        public CharacterFrequency(char aChar)
        {
            Character = aChar;
            Frequency = 1;
        }
        //public CharacterFrequency(char aChar, long charCount)
        //{
        //    Character = aChar;
        //    Frequency = charCount;
        //}

        public void IncrementFrequency()
        {
            _freq++;
        }

        public override bool Equals(object obj)
        {

            //if (obj == null) return false;
            //if (obj == this) return true;

            //if (!(obj is Student))
            //	return false;

            //Student student = obj as Student;

            //return this._id == student._id;


            if (obj == null) return false;

            if (obj == this) return true;

            if (!(obj is CharacterFrequency)) return false;

            CharacterFrequency ourCharObj = (CharacterFrequency)obj;
            return this.Character == ourCharObj.Character;

            //bool equal = false;
            //CharacterFrequency frequency = new CharacterFrequency((char)aChar);
            //frequency = (CharacterFrequency) aChar;
            //if (this.Character == frequency.Character) equal = true;
            //return equal;
        }

        public override string ToString()
        {
            string output = String.Format(_char + " " + "(" + (byte) _char + ")" + "\t" + " = " + _freq);
            return output;
        }

        public override int GetHashCode()
        {
            return (int)_freq;
        }
    }
}
