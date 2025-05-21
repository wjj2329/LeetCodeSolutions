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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode();
        ListNode curr = head;
        bool isOverFlow = false;
        while(l1!=null &&l2!=null){
            curr.val = l1.val+l2.val;
            curr.val +=isOverFlow?1:0;
            isOverFlow = curr.val>=10?true:false;
            if(isOverFlow){
                curr.val%=10;
            }
            l1 = l1.next;
            l2 = l2.next;
            if(l1!=null || l2!=null || isOverFlow)
                curr.next = new ListNode();
            curr = curr.next;
        }
        if(l1 == null){
            l1 = l2;
        }
        while(l1!=null){
            Console.WriteLine(curr);
            curr.val = l1.val;
            curr.val +=isOverFlow?1:0;
            isOverFlow = curr.val>=10?true:false;
            if(isOverFlow){
                curr.val%=10;
            }
            if(l1.next!=null||isOverFlow){
                curr.next=new ListNode();
            }
            l1 = l1.next;
            curr = curr.next;
        }
        if(isOverFlow){
            curr.val = 1;
        }
        return head;
    }
}