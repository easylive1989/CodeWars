using System;

namespace Kata
{
    public class ROT13
    {
        
        public string Rot13(string input)
        {
            var characters = input.ToCharArray();
            for (int idx = 0; idx < characters.Length ; idx++ )
            {
                characters[idx] = Rotate(characters[idx], 13);
            }
            return new String(characters);
        }

        private char Rotate(char character, int distance)
        {
            if (character >= 65 && character <= 90)
            {
                return (char)((character - 65 + distance) % 26 + 65);
            }

            if (character >= 97 && character <= 122)
            {
                return (char)((character - 97 + distance) % 26 + 97); ;
            }

            return character;
        }

    }
}
