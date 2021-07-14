namespace LeetCodeSolutions
{
    public class Solution
    {
        public string ReplaceDigits(string s)
        {
            char[] resultChars = new char[s.Length];

            for (int i = 0, j = 1; i < s.Length - 1; i += 2, j += 2)
            {
                resultChars[i] = s[i];
                resultChars[j] = (char) (s[i] + int.Parse(s[j] + ""));
            }

            if (s.Length % 2 != 0)
            {
                resultChars[s.Length - 1] = s[s.Length - 1];
            }

            return new string(resultChars);
        }
    }
}