using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            List<char> result = new List<char>();

            int aIndex = a.Length - 1;
            int bIndex = b.Length - 1;
            int carry = 0;

            while (aIndex >= 0 || bIndex >= 0 || carry > 0)
            {
                int aVal = aIndex >= 0 ? a[aIndex] - '0' : 0;
                int bVal = bIndex >= 0 ? b[bIndex] - '0' : 0;

                int sum = aVal + bVal + carry;

                result.Add((char) (sum % 2 + '0'));
                carry = sum / 2;

                aIndex--;
                bIndex--;
            }

            result.Reverse();
            return new string(result.ToArray());
        }
    }
}