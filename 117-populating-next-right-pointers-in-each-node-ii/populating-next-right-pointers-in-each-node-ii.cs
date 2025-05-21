/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
         if(root==null){
            return null;
        }
        Queue<Node>myQueue= new Queue<Node>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            int count = myQueue.Count;
            Node previous = null;
            for(int i = 0; i<count; i++){
                Node curr = myQueue.Dequeue();
                if(curr.right!=null){
                    myQueue.Enqueue(curr.right);
                }
                if(curr.left!=null){
                    myQueue.Enqueue(curr.left);
                }
                curr.next = previous; 
                previous = curr;
            }
        }
        return root;
    }
}