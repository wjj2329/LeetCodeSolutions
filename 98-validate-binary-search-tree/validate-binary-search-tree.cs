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
    public void Traverse(TreeNode curr, List<int>myList){
        if(curr==null){
            return;
        }
        Traverse(curr.left, myList);
        myList.Add(curr.val);
        Traverse(curr.right, myList);
    }
    public bool IsValidBST(TreeNode root) {
       List<int>myList = new List<int>();
       Traverse(root, myList);
       for(int i =1; i<myList.Count; i++){
           Console.WriteLine(myList[i]);
           if(myList[i]<=myList[i-1]){
               return false;
           }
       }
       return true;
    }
}