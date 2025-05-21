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
    int index; 
    double target;
    double closest=10000000; 
    public void Traverse(TreeNode curr){
        if(curr == null){
            return;
        }
        double distance = Math.Abs(curr.val - target);
        if(distance<closest){
            closest = distance;
            index = curr.val;
        }
        if(closest == distance){
            if(curr.val<index){
                index = curr.val;
            }
        }
        Traverse(curr.left);
        Traverse(curr.right);
    }
    public int ClosestValue(TreeNode root, double target) {
        this.target = target;
        Traverse(root);
        return index;
    }
}