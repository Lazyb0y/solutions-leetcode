using System;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            string nBinary = Convert.ToString(n, 2);

            int count = 0;
            for (int i = 0; i < nBinary.Length; i++)
            {
                if (nBinary[i] == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }
}