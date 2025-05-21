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
    int max = 0;
    public void Traverse(TreeNode curr, int streak){
        max = Math.Max(streak, max);
        if(curr.left!=null){
        if(curr.val+1 == curr.left.val){
            Traverse(curr.left, streak+1);
        }else{
            Traverse(curr.left, 1);
        }
        }
        if(curr.right!=null){
        if(curr.val+1 == curr.right.val){
            Traverse(curr.right, streak+1);
        }else{
            Traverse(curr.right, 1);
        }
        }
    }
    public int LongestConsecutive(TreeNode root) {
        if(root== null){
            return 0;
        }
        Traverse(root, 1);
        return max;
    }
}