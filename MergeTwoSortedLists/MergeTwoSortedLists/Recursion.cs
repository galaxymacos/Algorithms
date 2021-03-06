﻿namespace MergeTwoSortedLists
{
    public class Recursion
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            
            // compare the head of two ListNodes
            if (l1.Val < l2.Val)   
            {
                l1.Next = MergeTwoLists(l1.Next, l2);    
                return l1;    // l1 info = (l1.val) + MergeTwoLists(l1.Next, l2)
            }
            else
            {
                l2.Next = MergeTwoLists(l1, l2.Next);
                return l2;
            }

        }
        
    }
}