using System;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool HasAlternatingBits(int n)
        {
            string nBitString = Convert.ToString(n, 2);

            char last = nBitString[0];
            for (int i = 1; i < nBitString.Length; i++)
            {
                if (last == nBitString[i])
                {
                    return false;
                }

                last = nBitString[i];
            }

            return true;
        }
    }
}