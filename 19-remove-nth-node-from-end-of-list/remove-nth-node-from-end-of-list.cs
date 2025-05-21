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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count= 0;
        ListNode curr = head;
        while(curr!=null){
            count++;
            curr = curr.next;
        }
        int ammount = count-n; //off by 1?
        curr = head;
        for(int i = 0; i<ammount-1; i++){
            curr = curr.next;
        }
        if(ammount == 0){
            return head.next;
        }
        if(curr.next== null ||curr.next.next == null){
            curr.next = null;
        }else{
        curr.next = curr.next.next;
        }
        return head;

    }
}