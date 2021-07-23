namespace LeetCodeSolutions
{
    public class Solution
    {
        public int BalancedStringSplit(string s)
        {
            int count = 0;

            int lCount = 0;
            int rCount = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'L')
                {
                    lCount++;
                }
                else
                {
                    rCount++;
                }

                if (lCount == 0 && rCount == 0)
                {
                    continue;
                }

                if (lCount == rCount)
                {
                    count++;
                    lCount = 0;
                    rCount = 0;
                }
            }

            return count;
        }
    }
}