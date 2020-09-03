using System.Collections.Generic;

namespace Kata
{
    public class MyString
    {
        public string RemoveDuplicatedWord(string sentence)
        {
            var words = sentence.Split(' ');
            var distinctWords = new HashSet<string>(words);
            return string.Join(" ", distinctWords);
        }
    }
}