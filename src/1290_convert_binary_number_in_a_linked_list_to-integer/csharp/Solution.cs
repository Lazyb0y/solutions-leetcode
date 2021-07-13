namespace LeetCodeSolutions
{
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;

    //    public ListNode(int val = 0, ListNode next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}

    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            int[] binary = new int[30];

            int length = 0;
            for (int i = 0; i <= 30; i++)
            {
                if (head == null)
                {
                    length = i;
                    break;
                }

                binary[i] = head.val;
                head = head.next;
            }

            int decimalValue = 0;
            int factor = 1;
            for (int i = length - 1; i >= 0; i--)
            {
                decimalValue += binary[i] * factor;
                factor *= 2;
            }

            return decimalValue;
        }
    }
}