namespace MergeTwoSortedLists
{
    public class Iteration
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode prehead = new ListNode(-1);
            ListNode prev = prehead;

            while (l1 != null && l2 != null) // Append the smaller node to prev.Next until a linkedlist is empty
            {
                if (l1.Val < l2.Val)
                {
                    prev.Next = l1;
                    l1 = l1.Next;
                }
                else
                {
                    prev.Next = l2;
                    l2 = l2.Next;
                }
                prev = prev.Next;
            }

            prev.Next = l1 ?? l2;    // append the other non-empty linkedlist to the head of prev
            return prehead.Next;
        }
    }
}