namespace LeetCodeSolutions
{
    public class Solution
    {
        public int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            int length = 1;

            while (length <= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (length + i > arr.Length)
                    {
                        break;
                    }

                    for (int j = i; j < length + i; j++)
                    {
                        sum += arr[j];
                    }
                }

                length = length + 2;
            }

            return sum;
        }
    }
}