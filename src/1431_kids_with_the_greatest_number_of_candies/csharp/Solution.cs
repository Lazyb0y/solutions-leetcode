using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = 0;
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }

            IList<bool> result = new bool[candies.Length];
            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] + extraCandies >= max)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }
            }

            return result;
        }
    }
}