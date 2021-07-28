namespace LeetCodeSolutions
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int pointer = nums.Length;

            for (int i = 1; i < pointer; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    pointer--;

                    for (int j = i; j < pointer; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    i--;
                }
            }

            return pointer;
        }
    }
}