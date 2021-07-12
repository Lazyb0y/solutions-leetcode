using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (counts.ContainsKey(nums[i]))
                {
                    counts[nums[i]]++;
                }
                else
                {
                    counts.Add(nums[i], 1);
                }
            }

            int maxCount = 0;
            int maxNumber = 0;
            foreach (var count in counts)
            {
                if (count.Value > maxCount)
                {
                    maxNumber = count.Key;
                    maxCount = count.Value;
                }
            }

            return maxNumber;
        }
    }
}