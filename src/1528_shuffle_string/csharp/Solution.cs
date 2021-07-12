namespace LeetCodeSolutions
{
    public class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] sorted = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                sorted[indices[i]] = s[i];
            }

            return new string(sorted);
        }
    }
}