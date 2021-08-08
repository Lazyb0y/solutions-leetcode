using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            int[] result = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                result[i] = DecimalToBinary(i).Count(c => c == '1');
            }

            return result;
        }

        private string DecimalToBinary(int num)
        {
            string binary = "";

            while (num > 0)
            {
                binary = num % 2 + binary;
                num /= 2;
            }

            return binary;
        }
    }
}