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
    public ListNode RemoveElements(ListNode head, int val) {
        if(head == null){
            return head;
        }
        ListNode sent = new ListNode(-1);
        sent.next = head;
        ListNode curr = sent;
        while(curr !=null && curr.next!=null){
            var next = curr.next;
            while(next!=null && next.val==val){
                next = next.next;
            }
            curr.next = next;
            curr = curr.next;
        }
        return sent.next;
    }
}