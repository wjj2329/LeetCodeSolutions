/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }
        ListNode sentHead = new ListNode(0, head);
        ListNode curr = sentHead;
        while(curr!=null){
            ListNode temp = curr;
            bool skipped = false;
            while(temp.next!=null&& temp.next.next!=null && temp.next.val ==temp.next.next.val){
                temp= temp.next;
                skipped =true;
            }
            if(skipped){
                curr.next = temp.next.next;
            }else{
                curr = curr.next;
            }

        }
        return sentHead.next;
    }
}