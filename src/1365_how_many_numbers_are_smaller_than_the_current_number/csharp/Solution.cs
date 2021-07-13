using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            Dictionary<int, int> uniqueCount = new Dictionary<int, int>();

            int[] output = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (uniqueCount.ContainsKey(nums[i]))
                {
                    output[i] = uniqueCount[nums[i]];
                }
                else
                {
                    int count = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (i != j && nums[j] < nums[i])
                        {
                            count++;
                        }
                    }

                    output[i] = count;
                    uniqueCount.Add(nums[i], count);
                }
            }

            return output;
        }
    }
}