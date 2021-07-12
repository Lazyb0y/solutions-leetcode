namespace LeetCodeSolutions
{
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] image)
        {
            int[][] resultImage = new int[image.Length][];

            /* Flip the image */
            for (int i = 0; i < image.Length; i++)
            {
                int head = 0;
                int tail = image[i].Length - 1;

                while (head < tail)
                {
                    image[i][head] = image[i][head] ^ image[i][tail];
                    image[i][tail] = image[i][head] ^ image[i][tail];
                    image[i][head] = image[i][head] ^ image[i][tail];

                    head++;
                    tail--;
                }
            }

            /* Invert the image */
            for (int i = 0; i < image.Length; i++)
            {
                for (int j = 0; j < image[i].Length; j++)
                {
                    image[i][j] = image[i][j] ^ 1;
                }
            }

            return image;
        }
    }
}