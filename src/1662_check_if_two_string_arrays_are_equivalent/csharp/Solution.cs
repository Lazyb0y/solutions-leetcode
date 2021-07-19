using System.Text;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            StringBuilder string1 = new StringBuilder();
            StringBuilder string2 = new StringBuilder();

            foreach (var word in word1)
            {
                string1.Append(word);
            }

            foreach (var word in word2)
            {
                string2.Append(word);
            }

            return string1.Length == string2.Length && string1.ToString() == string2.ToString();
        }
    }
}