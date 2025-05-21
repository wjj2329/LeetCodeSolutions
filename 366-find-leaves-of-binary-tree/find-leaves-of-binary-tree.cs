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
    public void Recurse(TreeNode curr, List<int>myList){
        if(curr == null){
            return;
        }
        if(curr.left!=null && curr.left.left==null && curr.left.right == null){
            myList.Add(curr.left.val);
            curr.left = null;
        }
        if(curr.right!=null && curr.right.left==null && curr.right.right == null){
            myList.Add(curr.right.val);
            curr.right = null;
        }
        Recurse(curr.left, myList);
        Recurse(curr.right, myList);
    }
    public IList<IList<int>> FindLeaves(TreeNode root) {
        IList<IList<int>>myList = new List<IList<int>>();
        if(root == null){
            return myList;
        }
        while(root.left!=null || root.right!=null){
            List<int>temp = new List<int>();
            Recurse(root, temp);
            myList.Add(temp);
        }
        List<int>rootVal = new List<int>();
        rootVal.Add(root.val);
        myList.Add(rootVal);
        return myList;
    }
}