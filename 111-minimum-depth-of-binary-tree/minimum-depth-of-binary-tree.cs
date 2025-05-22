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
    int min = int.MaxValue;
    public void Recurse(TreeNode curr, int depth){
        if(curr.left == null && curr.right == null){
            min = Math.Min(depth, min);
            return;
        }
        if(curr.left!=null){
            Recurse(curr.left, depth+1);
        }
        if(curr.right!= null){
            Recurse(curr.right, depth+1);
        }
    }
    public int MinDepth(TreeNode root) {
        if(root == null){
            return 0;
        }
        min = int.MaxValue; 
        Recurse(root, 1);
        return min;
    }
}