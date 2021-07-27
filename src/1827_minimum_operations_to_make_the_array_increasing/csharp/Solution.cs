namespace LeetCodeSolutions
{
    public class Solution
    {
        public int MinOperations(int[] nums)
        {
            int minOperation = 0;

            int index = 0;

            while (index < nums.Length - 1)
            {
                if (nums[index] >= nums[index + 1])
                {
                    int toIncrement = nums[index] - nums[index + 1] + 1;
                    nums[index + 1] += toIncrement;
                    minOperation += toIncrement;
                }
                else
                {
                    index++;
                }
            }

            return minOperation;
        }
    }
}