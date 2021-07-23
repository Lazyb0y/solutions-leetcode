using System.Text;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if ('a' <= s[i] && s[i] <= 'z')
                {
                    builder.Append(s[i]);
                }
                else if ('0' <= s[i] && s[i] <= '9')
                {
                    builder.Append(s[i]);
                }
                else if ('A' <= s[i] && s[i] <= 'Z')
                {
                    builder.Append((char) (s[i] + 32));
                }
            }

            string processedString = builder.ToString();
            int head = 0;
            int tail = processedString.Length - 1;

            while (head < tail)
            {
                if (processedString[head] != processedString[tail])
                {
                    return false;
                }

                head++;
                tail--;
            }

            return true;
        }
    }
}