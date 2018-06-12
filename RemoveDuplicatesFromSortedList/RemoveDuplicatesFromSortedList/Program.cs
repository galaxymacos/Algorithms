using System;

namespace RemoveDuplicatesFromSortedList
{
    public class ListNode
    {
        public readonly int Val;
        public ListNode Next;

        public ListNode(int x)
        {
            Val = x;
        }
    }
    
    public class Myclass {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            ListNode headCopy = head;
            while (headCopy != null)
            {
                ListNode endSearcher = headCopy.Next;
                while (endSearcher != null&&headCopy.Val == endSearcher.Val)
                {
                    headCopy.Next = endSearcher.Next;
                    endSearcher = endSearcher.Next;
                    if (endSearcher == null)
                        break;
                }
                headCopy = headCopy.Next;
            }
            

            return head;
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            ListNode head = new ListNode(1) {Next = new ListNode(1)};
            Myclass myclass = new Myclass();
            myclass.DeleteDuplicates(head);
        }
    }
}