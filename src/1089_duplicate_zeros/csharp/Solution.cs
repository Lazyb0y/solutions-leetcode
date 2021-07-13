namespace LeetCodeSolutions
{
    public class Solution
    {
        public void DuplicateZeros(int[] arr)
        {
            int currentIndex = 0;

            while (currentIndex < arr.Length - 1)
            {
                if (arr[currentIndex] == 0)
                {
                    for (int i = arr.Length - 1; i > currentIndex; i--)
                    {
                        arr[i] = arr[i - 1];
                    }

                    currentIndex++;
                }

                currentIndex++;
            }
        }
    }
}