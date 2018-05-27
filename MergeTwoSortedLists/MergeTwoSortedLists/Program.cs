using System;

namespace MergeTwoSortedLists
{
    public class Recursion
    {
        
    }
    
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
                    prev.next = new ListNode(l2.val);
                    l2 = l2.next;
                    prev = prev.next;
                }
                else if (l2 == null)
                {
                    prev.next = new ListNode(l1.val);
                    l1 = l1.next;
                    prev = prev.next;
                }
                else if (l1.val < l2.val)
                {
                    prev.next = new ListNode(l1.val);
                    l1 = l1.next;
                    prev = prev.next;
                }
                else
                {
                    prev.next = new ListNode(l2.val);
                    l2 = l2.next;
                    prev = prev.next;
                }
            }

            return result.next;
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}