/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
    public Node child;
}
*/

public class Solution {
    public Node Flatten(Node head) {
        if(head == null){
            return head;
        }
        Stack<Node>myStack = new Stack<Node>();
        myStack.Push(head);
        Node previous = null;
        while(myStack.Count>0){
            Node current = myStack.Pop();
            if(current.next!=null){
                myStack.Push(current.next);
            }
            if(current.child!=null){
                myStack.Push(current.child);
            }
            current.prev = previous;
            current.next = myStack.Count>0?myStack.Peek():null;
            current.child = null;
            previous = current;
        }   
        return head;
    }
}