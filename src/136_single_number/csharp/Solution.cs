using System.Collections;

namespace LeetCodeSolutions
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < nums.Length; i++)
            {
                if (hashtable.ContainsKey(nums[i]))
                {
                    hashtable.Remove(nums[i]);
                }
                else
                {
                    hashtable.Add(nums[i], null);
                }
            }

            foreach (DictionaryEntry hashEntry in hashtable)
            {
                return (int) hashEntry.Key;
            }

            return nums[0];
        }
    }
}