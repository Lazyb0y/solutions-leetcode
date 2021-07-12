namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] CreateTargetArray(int[] nums, int[] index)
        {
            int[] result = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > index[i])
                {
                    for (int j = nums.Length - 1; j > index[i]; j--)
                    {
                        result[j] = result[j - 1];
                    }
                }

                result[index[i]] = nums[i];
            }

            return result;
        }
    }
}