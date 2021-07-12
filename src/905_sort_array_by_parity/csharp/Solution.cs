using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            List<int> oddNumbers = new List<int>();
            List<int> evenNumbers = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] & 1) == 0)
                {
                    evenNumbers.Add(nums[i]);
                }
                else
                {
                    oddNumbers.Add(nums[i]);
                }
            }

            int[] output = new int[nums.Length];

            int iterator = 0;

            foreach (var evenNumber in evenNumbers)
            {
                output[iterator] = evenNumber;
                iterator++;
            }

            foreach (var oddNumber in oddNumbers)
            {
                output[iterator] = oddNumber;
                iterator++;
            }

            return output;
        }
    }
}