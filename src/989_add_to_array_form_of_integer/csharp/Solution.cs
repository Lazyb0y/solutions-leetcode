using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            List<int> result = new List<int>();

            int i = num.Length - 1;
            int carry = 0;
            while (i >= 0 || k > 0 || carry > 0)
            {
                int n = i >= 0 ? num[i] : 0;
                int remainder = k % 10;
                int sum = n + remainder + carry;
                result.Add(sum % 10);

                carry = sum / 10;
                k /= 10;
                i--;
            }

            result.Reverse();
            return result;
        }
    }
}