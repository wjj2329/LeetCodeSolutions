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
    public ListNode ReverseList(ListNode head) {
        ListNode temp = head;
        ListNode next = null;
        while(temp!=null){
            ListNode something = temp.next;
            temp.next = next;
            next = temp;
            temp = something;
        }
        return next;
    }
}