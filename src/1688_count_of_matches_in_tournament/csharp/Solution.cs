namespace LeetCodeSolutions
{
    public class Solution
    {
        public int NumberOfMatches(int n)
        {
            int numberOfMatches = 0;

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    numberOfMatches += n;
                }
                else
                {
                    n = (n - 1) / 2 + 1;
                    numberOfMatches += n - 1;
                }
            }

            return numberOfMatches;
        }
    }
}