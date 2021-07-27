namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool HalvesAreAlike(string s)
        {
            int halfLen = s.Length / 2;
            int vowelCount = 0;

            for (int i = 0; i < halfLen; i++)
            {
                if (IsVowel(s[i]))
                {
                    vowelCount++;
                }
            }

            for (int i = halfLen; i < s.Length; i++)
            {
                if (IsVowel(s[i]))
                {
                    vowelCount--;
                }
            }

            return vowelCount == 0;
        }

        private bool IsVowel(char c)
        {
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    return true;
            }

            return false;
        }
    }
}