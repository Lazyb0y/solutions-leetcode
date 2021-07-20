using System;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int HammingDistance(int x, int y)
        {
            string xBinary = new string(Convert.ToString(x, 2).ToCharArray().Reverse().ToArray());
            string yBinary = new string(Convert.ToString(y, 2).ToCharArray().Reverse().ToArray());

            int distance = 0;
            for (int i = 0; i < (xBinary.Length > yBinary.Length ? xBinary.Length : yBinary.Length); i++)
            {
                if (i >= xBinary.Length || i >= yBinary.Length)
                {
                    if (i >= xBinary.Length && yBinary[i] == '1')
                    {
                        distance++;
                    }

                    if (i >= yBinary.Length && xBinary[i] == '1')
                    {
                        distance++;
                    }
                }
                else if (xBinary[i] != yBinary[i])
                {
                    distance++;
                }
            }

            return distance;
        }
    }
}