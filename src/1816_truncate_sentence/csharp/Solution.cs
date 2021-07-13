namespace LeetCodeSolutions
{
    public class Solution
    {
        public string TruncateSentence(string s, int k)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (k == 0)
                {
                    return s.Substring(0, i - 1);
                }

                if (s[i] == ' ')
                {
                    k--;
                }
            }

            return s;
        }
    }
}