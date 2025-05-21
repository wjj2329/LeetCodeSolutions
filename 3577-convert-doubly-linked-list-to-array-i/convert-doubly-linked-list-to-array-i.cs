/*
// Definition for a Node.
public class Node {
    public int val;
    public Node prev;
    public Node next;
}
*/

public class Solution {
    public int[] ToArray(Node head) {
        int size = 0;
        Node temp = head;
        while(temp!=null){
            temp = temp.next;
            size++;
        }
        int[]result = new int[size];
        temp = head;

        for(int i = 0; i<size; i++){
            result[i]= temp.val;
            temp = temp.next;
        }
        return result;
    }
}