namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string inputString = x.ToString();

            int loopTime = (inputString.Length / 2) + 1;
            for (int i = 0; i < loopTime; i++)
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