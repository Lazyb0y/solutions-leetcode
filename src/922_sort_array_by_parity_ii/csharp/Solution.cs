namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] SortArrayByParityII(int[] nums)
        {
            int[] output = new int[nums.Length];
            int evenPtr = 0;
            int oddPtr = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    output[evenPtr] = nums[i];
                    evenPtr += 2;
                }
                else
                {
                    output[oddPtr] = nums[i];
                    oddPtr += 2;
                }
            }
            
            return output;
        }
    }
}