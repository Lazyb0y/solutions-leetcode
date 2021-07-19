using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] DecompressRLElist(int[] nums)
        {
            List<int> resultList = new List<int>();

            for (int i = 0; i < nums.Length; i = i + 2)
            {
                for (int j = 0; j < nums[i]; j++)
                {
                    resultList.Add(nums[i + 1]);
                }
            }

            return resultList.ToArray();
        }
    }
}