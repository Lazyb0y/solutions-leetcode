namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string inputString = x.ToString();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != inputString[inputString.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}