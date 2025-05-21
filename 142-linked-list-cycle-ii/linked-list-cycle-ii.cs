/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        HashSet<ListNode>visited = new HashSet<ListNode>();
        while(head!=null &&head.next!=null){
            if(visited.Contains(head)){
                return head;
            }
            visited.Add(head);
            head = head.next;
        }
        return null;
    }
}