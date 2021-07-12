using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                {
                    return nums[i];
                }

                hashSet.Add(nums[i]);
            }

            return nums[1];
        }
    }
}