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
    public ListNode DeleteDuplicatesUnsorted(ListNode head) {
        HashSet<int>appeared = new HashSet<int>();
        HashSet<int>needRemoving = new HashSet<int>();
        ListNode curr = head;
        while(curr!=null){
            if(!appeared.Contains(curr.val)){
                appeared.Add(curr.val);
            }else{
                needRemoving.Add(curr.val);
            }
            curr = curr.next;
        }
        curr = new ListNode(-1);
        curr.next = head;
        head = curr;
        bool isDeleting = false;
        ListNode previous = null;
        ListNode keeping = null;
        Console.WriteLine(needRemoving.Count);
        while(curr!=null){
            if(!isDeleting){
                if(needRemoving.Contains(curr.val)){
                    keeping = previous;
                    isDeleting = true;
                }
            }else{
                if(!needRemoving.Contains(curr.val)){
                    Console.WriteLine(keeping.val +" "+curr.val);
                    isDeleting = false;
                    keeping.next = curr;
                }
            }
            previous = curr;
            curr = curr.next;
        }
        if(isDeleting){
            keeping.next = null;
        }
        return head.next;
    }
}