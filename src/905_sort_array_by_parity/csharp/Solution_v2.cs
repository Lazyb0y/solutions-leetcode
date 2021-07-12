namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int evenPointer = 0;
            int oddPointer = nums.Length - 1;

            int currentIndex = 0;
            while (evenPointer < oddPointer)
            {
                if ((nums[currentIndex] & 1) == 0)
                {
                    evenPointer++;
                    currentIndex++;
                }
                else
                {
                    int temp = nums[currentIndex];
                    nums[currentIndex] = nums[oddPointer];
                    nums[oddPointer] = temp;

                    oddPointer--;
                }
            }

            return nums;
        }
    }
}