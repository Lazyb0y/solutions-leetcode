namespace LeetCodeSolutions
{
    public class Solution
    {
        public int FindNumbers(int[] nums)
        {
            int evenCount = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];

                int length = 0;
                while (num != 0)
                {
                    num = num / 10;
                    length++;
                }

                if (length % 2 == 0)
                {
                    evenCount++;
                }
            }

            return evenCount;
        }
    }
}