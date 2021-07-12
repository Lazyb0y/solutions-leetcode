namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[] Decode(int[] encoded, int first)
        {
            int[] decode = new int[encoded.Length + 1];
            decode[0] = first;

            for (int i = 0; i < encoded.Length; i++)
            {
                decode[i + 1] = decode[i] ^ encoded[i];
            }

            return decode;
        }
    }
}