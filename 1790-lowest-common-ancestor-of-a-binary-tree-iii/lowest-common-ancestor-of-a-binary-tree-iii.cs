/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/

public class Solution {
    public Node LowestCommonAncestor(Node p, Node q) {
        HashSet<Node>pPath = new HashSet<Node>();
        while(p!=null){
            pPath.Add(p);
            p=p.parent;
        }
        while(!pPath.Contains(q)){
            q= q.parent;
        }
        return q;
    }
}