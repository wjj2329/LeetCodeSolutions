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
    public IList<int> RightSideView(TreeNode root) {
        List<int>myList = new List<int>();
        if(root == null){
            return myList;
        }
        Queue<TreeNode>myQueue= new Queue<TreeNode>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            int levelCount = myQueue.Count;
            for(int i = 0; i<levelCount; i++){
            TreeNode curr = myQueue.Dequeue();
            if(curr.right!=null){
                myQueue.Enqueue(curr.right);
            }
            if(curr.left!=null){
                myQueue.Enqueue(curr.left);
            }
            if(i==0){
                myList.Add(curr.val);
            }
            }
        }
        return myList;
    }
}