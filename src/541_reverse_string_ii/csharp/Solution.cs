namespace LeetCodeSolutions
{
    public class Solution
    {
        public string ReverseStr(string s, int k)
        {
            char[] reverseChars = new char[s.Length];

            bool reverseMode = true;

            for (int i = 0; i < s.Length; i = i + k)
            {
                int tail = (i + k < s.Length ? k : s.Length - i) + i;
                if (reverseMode)
                {
                    int head = i;
                    for (int j = tail - 1; j >= i; j--)
                    {
                        reverseChars[head] = s[j];
                        head++;
                    }
                }
                else
                {
                    for (int j = i; j < tail; j++)
                    {
                        reverseChars[j] = s[j];
                    }
                }

                reverseMode = !reverseMode;
            }

            return new string(reverseChars);
        }
    }
}