namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }

            int initial = x;
            int reverse = 0;

            while (initial != 0)
            {
                reverse = reverse * 10 + initial % 10;
                initial /= 10;
            }

            if (x == reverse)
            {
                return true;
            }

            return false;
        }
    }
}