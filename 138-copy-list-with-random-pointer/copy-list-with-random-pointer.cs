/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head==null){
            return null;
        }
        Node newHead = new Node(head.val);
        Node newCurr = newHead;
        Node curr = head;
        Dictionary<Node, Node>created = new Dictionary<Node, Node>();
        created.Add(head,newHead);
        while(curr!=null){
            Console.WriteLine(curr.val);
            if(curr.next!=null){
                if(!created.ContainsKey(curr.next)){
                    created.Add(curr.next, new Node(curr.next.val));
                }
                newCurr.next = created[curr.next];
            }
            if(curr.random!=null){
                if(!created.ContainsKey(curr.random)){
                    created.Add(curr.random, new Node(curr.random.val));
                }
                newCurr.random = created[curr.random];
            }
            newCurr = newCurr.next;
            curr = curr.next;
        }
        return newHead;
    }
}