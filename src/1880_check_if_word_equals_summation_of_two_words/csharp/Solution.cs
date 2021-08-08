namespace LeetCodeSolutions
{
    public class Solution
    {
        public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
        {
            int numOfFirstWord = 0;
            int numOfSecondWord = 0;
            int numOfTargetWord = 0;

            for (int i = 0; i < firstWord.Length; i++)
            {
                numOfFirstWord = numOfFirstWord * 10 + (firstWord[i] - 'a');
            }

            for (int i = 0; i < secondWord.Length; i++)
            {
                numOfSecondWord = numOfSecondWord * 10 + (secondWord[i] - 'a');
            }

            for (int i = 0; i < targetWord.Length; i++)
            {
                numOfTargetWord = numOfTargetWord * 10 + (targetWord[i] - 'a');
            }

            return numOfFirstWord + numOfSecondWord == numOfTargetWord;
        }
    }
}