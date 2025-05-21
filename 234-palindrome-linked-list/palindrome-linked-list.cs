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
    public bool IsPalindrome(ListNode head) {
        Stack<ListNode>myStack = new Stack<ListNode>();
        Queue<ListNode>myQueue = new Queue<ListNode>();
        int length = 0;
        while(head!=null){
            length++;
            myStack.Push(head);
            myQueue.Enqueue(head);
            head = head.next;
        }
        for(int i = 0; i<length/2; i++){
            if(myStack.Pop().val!=myQueue.Dequeue().val){
                return false;
            }
        }
        return true;
    }
}