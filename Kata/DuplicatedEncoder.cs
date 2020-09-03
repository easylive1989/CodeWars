using System.Linq;

namespace Kata
{
    // https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/csharp
    // 6 kyu
    public class DuplicatedEncoder
    {
        public string Encode(string word)
        {
            var charArray = word.ToLower().ToArray();
            var charGroups = charArray.GroupBy(x => x);
            return charArray.Aggregate("",
                (duplicatedString, character) =>
                    duplicatedString + (charGroups.First(x => x.Key == character).Count() > 1 ? ")" : "("));
        }
    }
}