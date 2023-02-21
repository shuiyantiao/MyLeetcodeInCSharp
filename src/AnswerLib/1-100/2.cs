namespace AnswerLib._1_100
{
    public class _2
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool flag = false;
            var head = l1;
            while (l1 != null && l2 != null)
            {
                l1.val += l2.val;

                if (l1.next != null && l2.next != null)
                {
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else
                {
                    break;
                }
            }
            if (l2.next != null)
            {
                l1.next = l2.next;
            }
            for (l1 = head; l1 != null; l1 = l1.next)
            {
                if (flag == true)
                {
                    l1.val += 1;
                    flag = false;
                }
                if (l1.val >= 10)
                {
                    l1.val -= 10;
                    flag = true;
                    if (l1.next == null)
                    {
                        l1.next = new ListNode();
                    }
                }
            }
            return head;
        }
    }
}
