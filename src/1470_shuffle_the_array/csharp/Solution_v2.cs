namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] output = new int[nums.Length];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                output[index] = nums[i];
                index++;
                output[index] = nums[n + i];
                index++;
            }

            return output;
        }
    }
}