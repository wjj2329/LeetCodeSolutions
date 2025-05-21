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
    int maxLevel = 0; 
    public void Recurse(TreeNode current, int level){
        if(current==null){
            return;
        }
        maxLevel = Math.Max(level, maxLevel);
        Recurse(current.left, level+1);
        Recurse(current.right, level+1);
    }
    public int MaxDepth(TreeNode root) {
        if(root == null){
            return 0;
        }
         Recurse(root, 1);
         return maxLevel;
    }
}