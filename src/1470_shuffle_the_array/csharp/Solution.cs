namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            int[] xElements = new int[n];
            int[] yElements = new int[n];

            for (int i = 0; i < n; i++)
            {
                xElements[i] = nums[i];
                yElements[i] = nums[i + n];
            }

            int[] output = new int[nums.Length];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                output[index] = xElements[i];
                index++;
                output[index] = yElements[i];
                index++;
            }

            return output;
        }
    }
}