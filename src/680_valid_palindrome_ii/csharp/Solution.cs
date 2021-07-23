namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool ValidPalindrome(string s)
        {
            int head = 0;
            int tail = s.Length - 1;

            while (head < tail)
            {
                if (s[head] != s[tail])
                {
                    return IsPalindrome(s, head + 1, tail) || IsPalindrome(s, head, tail - 1);
                }

                head++;
                tail--;
            }

            return true;
        }

        public bool IsPalindrome(string s, int head, int tail)
        {
            while (head < tail)
            {
                if (s[head] != s[tail])
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