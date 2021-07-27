using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string FreqAlphabets(string s)
        {
            List<char> output = new List<char>();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '#')
                {
                    output.Add((char) (int.Parse(s.Substring(i - 2, 2)) - 1 + 'a'));
                    i -= 2;
                }
                else
                {
                    output.Add((char) (int.Parse(s[i].ToString()) - 1 + 'a'));
                }
            }

            output.Reverse();
            return new string(output.ToArray());
        }
    }
}