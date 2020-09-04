using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public class MyString
    {
        // https://www.codewars.com/kata/5b39e3772ae7545f650000fc
        // 7 kyu
        public string RemoveDuplicatedWord(string sentence)
        {
            var words = sentence.Split(' ');
            var distinctWords = new HashSet<string>(words);
            return string.Join(" ", distinctWords);
        }

        public string ReverseAndCombineText(string text)
        {
            return text.Split(' ').Aggregate("", (reverseText, word) => reverseText + string.Join("", new Stack<char>(word.ToArray())));
            // var reverseWords = new List<string>();
            // foreach (var word in words)
            // {
            //     var chars = new Stack<char>(word.ToArray());
            //     reverseWords.Add(string.Join("", chars));
            // }
            //
            // return string.Join("", reverseWords);
            
            // var words = text.Split(' ').ToList();
            // var reverseWords = new List<string>();
            // foreach (var word in words)
            // {
            //     var chars = new Stack<char>(word.ToArray());
            //     reverseWords.Add(string.Join("", chars));
            // }
            //
            // return string.Join("", reverseWords);
        }
    }
}