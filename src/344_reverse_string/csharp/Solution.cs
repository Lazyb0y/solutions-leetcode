namespace LeetCodeSolutions
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int head = 0;
            int tail = s.Length - 1;

            char temp;
            while (head < tail)
            {
                temp = s[head];
                s[head] = s[tail];
                s[tail] = temp;

                head++;
                tail--;
            }
        }
    }
}