/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    IList<int>nodes = new List<int>();
    public void Traverse(TreeNode curr){
        if(curr==null){
            return;
        }
        Traverse(curr.left);
        nodes.Add(curr.val);
        Traverse(curr.right);
    }
    public IList<int> InorderTraversal(TreeNode root) {
        Traverse(root);
        return nodes;
    }
}