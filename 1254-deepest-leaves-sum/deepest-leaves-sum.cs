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

    public int DeepestLeavesSum(TreeNode root) {
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        int runningCount = 0;
        while(myQueue.Count>0){
            int count = myQueue.Count;
            int currCount = 0; 
            for(int i = 0; i<count; i++){
                TreeNode curr = myQueue.Dequeue();
                currCount+=curr.val;
                if(curr.left!=null){
                    myQueue.Enqueue(curr.left);
                }
                if(curr.right!=null){
                    myQueue.Enqueue(curr.right);
                }
            }
            runningCount= currCount;
        }
        return runningCount;
    }
}