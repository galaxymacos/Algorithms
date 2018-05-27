namespace MergeTwoSortedLists
{
    public class MyClass
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;


            var result = new ListNode(0);
            var prev = result;
            while (l1!= null || l2!= null)    // keep merging
            {
                if (l1 == null)
                {
                    prev.Next = new ListNode(l2.Val);
                    l2 = l2.Next;
                    prev = prev.Next;
                }
                else if (l2 == null)
                {
                    prev.Next = new ListNode(l1.Val);
                    l1 = l1.Next;
                    prev = prev.Next;
                }
                else if (l1.Val < l2.Val)
                {
                    prev.Next = new ListNode(l1.Val);
                    l1 = l1.Next;
                    prev = prev.Next;
                }
                else
                {
                    prev.Next = new ListNode(l2.Val);
                    l2 = l2.Next;
                    prev = prev.Next;
                }
            }

            return result.Next;
        }
    }
}