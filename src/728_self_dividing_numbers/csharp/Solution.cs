using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> self = new List<int>();

            for (int i = left; i <= right; i++)
            {
                int digit = i;

                bool selfDividing = true;
                while (digit != 0)
                {
                    int remainder = digit % 10;

                    if (remainder == 0)
                    {
                        selfDividing = false;
                        break;
                    }

                    if (i % remainder != 0)
                    {
                        selfDividing = false;
                        break;
                    }

                    digit = digit / 10;
                }

                if (selfDividing)
                {
                    self.Add(i);
                }
            }

            return self;
        }
    }
}