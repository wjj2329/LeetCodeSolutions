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
    public ListNode MergeKLists(ListNode[] lists) {
        SortedDictionary<int, List<ListNode>>myMap =  new SortedDictionary<int, List<ListNode>>();
        for(int i =0; i<lists.Length; i++){
            var c = lists[i];
            while(c!=null){
                if(!myMap.ContainsKey(c.val)){
                    myMap.Add(c.val, new List<ListNode>());
                }
                myMap[c.val].Add(c);
                c=c.next;
            }
        }
        ListNode head = new ListNode(-1);
        ListNode curr = head;
        while(myMap.Keys.Count >0){
            var first = myMap.First();
            for(int i = 0; i<myMap[first.Key].Count; i++){
                curr.next = myMap[first.Key][i];
                curr = curr.next;
            }
            curr.next=null;
            myMap.Remove(first.Key);
        }
        return head.next;

    }
}