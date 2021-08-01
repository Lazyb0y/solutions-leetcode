using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int SumOfUnique(int[] nums)
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

            int sum = 0;

            foreach (var num in count)
            {
                if (num.Value == 1)
                {
                    sum += num.Key;
                }
            }

            return sum;
        }
    }
}