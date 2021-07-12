using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int RepeatedNTimes(int[] nums)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (count.ContainsKey(nums[i]))
                {
                    count[nums[i]]++;
                }
                else
                {
                    count.Add(nums[i], 1);
                }
            }

            int n = nums.Length / 2;

            foreach (var item in count)
            {
                if (item.Value == n)
                {
                    return item.Key;
                }
            }

            return nums[0];
        }
    }
}