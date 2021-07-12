using System;
using System.Text;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string ToLowerCase(string s)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if ('A' <= s[i] && s[i] <= 'Z')
                {
                    builder.Append(Convert.ToChar(s[i] + 32));
                }
                else
                {
                    builder.Append(s[i]);
                }
            }

            return builder.ToString();
        }
    }
}