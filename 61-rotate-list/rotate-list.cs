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
    public ListNode RotateRight(ListNode head, int k) {
        if(head == null || head.next == null || k ==0){
            return head;
        }
         int size = 0;
         ListNode temp = head;
         while(temp!=null){
             size++;
             temp = temp.next;
         }
         k = k%size;
         if(k ==0){
             return head;
         }
         temp = head;
         for(int i =0; i<(size-k); i++){
             temp = temp.next;
         }
         ListNode newHead = temp;
         while(temp.next!=null){
             temp = temp.next;
         }
         temp.next = head;
         ListNode c = newHead;
         for(int i =0; i<size-1; i++){
             c = c.next;
         }
         c.next = null;
         return newHead;
    }
}