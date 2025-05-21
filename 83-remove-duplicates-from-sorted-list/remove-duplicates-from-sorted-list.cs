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
        ListNode curr = head;
        while(curr!=null){
            ListNode temp = curr;
            bool skip = false; 
            while(temp.next!=null&&temp.val== temp.next.val){
                temp = temp.next;
                skip = true;
            }
            if(skip){
            curr.next= temp.next;
            }else{
            curr = curr.next; 
            }
        }
        return head;
    }
}