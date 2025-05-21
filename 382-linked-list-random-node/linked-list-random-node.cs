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

    ListNode head;
    Random rand;
    public Solution(ListNode head) {
        this.head =head;
        rand = new Random();
    }
    
    public int GetRandom() {
        ListNode temp = head;
        int result = -1;
        int count =0; 
        while(temp!=null){
            count++;
            int lucky = rand.Next(0, count);
            if(lucky == 0){
                result = temp.val;
            }
            temp = temp.next;
        }
        return result;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */