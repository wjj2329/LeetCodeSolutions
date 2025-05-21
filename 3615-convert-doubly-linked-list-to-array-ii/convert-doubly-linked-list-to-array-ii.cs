/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
}
*/

public class Solution {
    public int[] ToArray(Node node) {
        Node findTail = node;
        int count = 0; 
        while(findTail!=null){
            findTail = findTail.next;
            count++;
        }
        Node findHead = null;
        if(node.prev!=null){
            findHead= node.prev;
        }
        Node head = null;
        while(findHead!=null){
            head = findHead;
            findHead= findHead.prev;
            count++;
        }
        int [] child = new int[count];
        if(head  == null){
            head = node;
        }
        for(int i = 0; i<count; i++){
            child[i]= head.val;
            head = head.next;
        }
        return child;
    }
}