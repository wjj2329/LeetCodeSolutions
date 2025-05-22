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
    public void Recurse(TreeNode current){
        if(current == null){
            return;
        }
        var temp = current.left;
        current.left = current.right;
        current.right = temp;
        Recurse(current.left);
        Recurse(current.right);
    }
    public TreeNode InvertTree(TreeNode root) {
        Recurse(root);
        return root;
    }
}