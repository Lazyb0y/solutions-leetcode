using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int ThirdMax(int[] nums)
        {
            HashSet<int> distinctNums = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                distinctNums.Add(nums[i]);
            }

            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            int thirdMax = int.MinValue;

            for (int i = 0; i < distinctNums.Count; i++)
            {
                int element = distinctNums.ElementAt(i);
                if (element > firstMax)
                {
                    thirdMax = secondMax;
                    secondMax = firstMax;
                    firstMax = element;
                }
                else if (element > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = element;
                }
                else if (element > thirdMax)
                {
                    thirdMax = element;
                }
            }

            if (distinctNums.Count < 3)
            {
                return firstMax;
            }

            return thirdMax;
        }
    }
}