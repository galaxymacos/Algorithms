namespace MergeTwoSortedLists
{
    public class MyClass
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;    // TODO optimize
            if (l2 == null) return l1;


            var result = new ListNode(0);    // TODO optimize
            var prev = result;
            while (l1!= null || l2!= null)    // keep merging TODO optimize
            {
                if (l1 == null)
                {
                    prev.Next = new ListNode(l2.Val);    // TODO optimize
                    l2 = l2.Next;
                    prev = prev.Next;    // TODO optimize
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