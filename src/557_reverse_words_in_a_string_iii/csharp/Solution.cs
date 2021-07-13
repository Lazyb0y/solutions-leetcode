namespace LeetCodeSolutions
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                int head = 0;
                int tail = words[i].Length - 1;

                char[] reversedWord = new char[words[i].Length];
                while (head <= tail)
                {
                    reversedWord[head] = words[i][tail];
                    reversedWord[tail] = words[i][head];
                    head++;
                    tail--;
                }

                words[i] = new string(reversedWord);
            }

            return string.Join(" ", words);
        }
    }
}