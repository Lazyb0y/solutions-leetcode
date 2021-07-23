namespace LeetCodeSolutions
{
    public class Solution
    {
        public string GcdOfStrings(string str1, string str2)
        {
            int maxLength = str1.Length < str2.Length ? str1.Length : str2.Length;

            while (maxLength > 0)
            {
                string divisor = str1.Substring(0, maxLength);
                if (CheckGreatestCommonDivisor(str1, divisor) && CheckGreatestCommonDivisor(str2, divisor))
                {
                    return divisor;
                }

                maxLength--;
            }

            return "";
        }

        public bool CheckGreatestCommonDivisor(string s, string divisor)
        {
            if (s.Length % divisor.Length != 0)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i = i + divisor.Length)
            {
                for (int j = 0; j < divisor.Length; j++)
                {
                    if (divisor[j] != s[i + j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}