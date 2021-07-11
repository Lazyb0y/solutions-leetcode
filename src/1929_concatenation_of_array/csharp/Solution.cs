namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] GetConcatenation(int[] nums)
        {
            int[] output = new int[nums.Length + nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                output[i] = output[nums.Length + i] = nums[i];
            }

            return output;
        }
    }
}