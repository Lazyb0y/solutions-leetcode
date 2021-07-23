using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> resultList = new List<int>();

            int carry = 0;
            int i = digits.Length - 1;
            int one = 1;

            while (i >= 0 || one > 0 || carry > 0)
            {
                int digit = i >= 0 ? digits[i] : 0;
                int oneDigit = one % 10;
                int sum = digit + oneDigit + carry;

                resultList.Add(sum % 10);

                one = one / 10;
                carry = sum / 10;
                i--;
            }

            resultList.Reverse();
            return resultList.ToArray();
        }
    }
}