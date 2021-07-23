using System.Linq;
using System.Text;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public string AddStrings(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();

            int num1Index = num1.Length - 1;
            int num2Index = num2.Length - 1;
            int carry = 0;

            while (num1Index >= 0 || num2Index >= 0 || carry > 0)
            {
                int n1 = num1Index >= 0 ? num1[num1Index] - '0' : 0;
                int n2 = num2Index >= 0 ? num2[num2Index] - '0' : 0;

                int sum = n1 + n2 + carry;
                result.Append(sum % 10);
                carry = sum / 10;

                num1Index--;
                num2Index--;
            }

            return new string(result.ToString().Reverse().ToArray());
        }
    }
}