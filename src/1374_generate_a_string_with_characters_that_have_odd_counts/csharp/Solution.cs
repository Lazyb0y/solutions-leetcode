namespace LeetCodeSolutions
{
    public class Solution
    {
        public string GenerateTheString(int n)
        {
            char[] stringChars = new char[n];

            if (n % 2 != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    stringChars[i] = 'a';
                }
            }
            else
            {
                stringChars[0] = 'a';

                for (int i = 1; i < n; i++)
                {
                    stringChars[i] = 'b';
                }
            }

            return new string(stringChars);
        }
    }
}