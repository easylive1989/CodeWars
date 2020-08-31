using System.Text;

namespace Kata
{
    //https://www.codewars.com/kata/5727bb0fe81185ae62000ae3/train/csharp
    //6 kyu
    public class BackspacesString
    {
        public string CleanString(string input)
        {
            var cleanString = new StringBuilder();
            foreach (var character in input.ToCharArray())
            {
                if (character == '#')
                {
                    if (cleanString.Length > 0)
                    {
                        cleanString.Remove(cleanString.Length - 1, 1);
                    }
                }
                else
                {
                    cleanString.Append(character);
                }
            }

            return cleanString.ToString();
        }
    }
}