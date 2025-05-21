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
    public void Flatten(TreeNode root) {
        if(root == null){
            return;
        }
        Stack<TreeNode> myStack= new Stack<TreeNode>();
        myStack.Push(root);
        TreeNode prev = null;
        while(myStack.Count>0){
            TreeNode curr = myStack.Pop();
            if(curr.right!=null){
                myStack.Push(curr.right);
            }
            if(curr.left!=null){
                myStack.Push(curr.left);
            }
            if(prev!=null){
                prev.right = curr;
                prev.left = null;
            }
            prev = curr;
        }
    }
}