namespace LeetCodeSolutions
{
    public class Solution
    {
        public int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int product = 1;

            while (n > 0)
            {
                var remainder = n % 10;
                n = n / 10;

                sum += remainder;
                product *= remainder;
            }

            return product - sum;
        }
    }
}