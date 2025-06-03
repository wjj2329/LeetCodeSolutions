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
    public void Traverse(TreeNode curr, List<int>result){
        if(curr==null){
            return;
        }
        result.Add(curr.val);
        Traverse(curr.left, result);
        Traverse(curr.right, result);
    }
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int>myList = new List<int>();
        Traverse(root, myList);
        return myList;
    }
}