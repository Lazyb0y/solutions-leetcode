namespace LeetCodeSolutions
{
    public class Solution
    {
        public int Maximum69Number(int num)
        {
            char[] numChars = num.ToString().ToCharArray();

            for (int i = 0; i < numChars.Length; i++)
            {
                if (numChars[i] == '6')
                {
                    numChars[i] = '9';
                    break;
                }
            }

            return int.Parse(new string(numChars));
        }
    }
}