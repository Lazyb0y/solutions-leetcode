using System.Collections.Generic;
using System.Linq;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>();

            for (int i = 1; i <= nums.Length; i++)
            {
                numSet.Add(i);
            }

            foreach (var num in nums)
            {
                if (numSet.Contains(num))
                {
                    numSet.Remove(num);
                }
            }

            return numSet.ToArray();
        }
    }
}