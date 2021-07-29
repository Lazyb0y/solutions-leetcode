using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();

            while (n != 1)
            {
                if (uniqueNumbers.Contains(n))
                {
                    return false;
                }

                uniqueNumbers.Add(n);

                int sum = 0;
                while (n != 0)
                {
                    sum = sum + (n % 10) * (n % 10);
                    n /= 10;
                }

                n = sum;
            }

            return true;
        }
    }
}