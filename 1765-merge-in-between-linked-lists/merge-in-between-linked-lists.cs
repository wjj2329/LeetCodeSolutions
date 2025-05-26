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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
        ListNode head = list1;
        for(int i = 0; i<a-1; i++){
            list1 = list1.next;
        }
        ListNode list1Tail = list1.next;
        list1.next = list2;
        ListNode list2Tail = list2;
        while(list2Tail.next!=null){
            list2Tail = list2Tail.next;
        }
        for(int i = 0; i<(b-a)+1; i++){
            list1Tail = list1Tail.next;
        }
        list2Tail.next = list1Tail;
        return head;
    }
}