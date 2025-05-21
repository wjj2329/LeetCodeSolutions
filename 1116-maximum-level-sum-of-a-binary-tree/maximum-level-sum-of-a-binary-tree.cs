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
    public int MaxLevelSum(TreeNode root) {
            Queue<TreeNode>myQueue= new Queue<TreeNode>();
            myQueue.Enqueue(root);
            int level = 0;
            int maxSum = int.MinValue;
            int bestLevel = -1;
            while(myQueue.Count>0){
                int levelCount = myQueue.Count;
                int sum =0;
                level++;
                for(int i = 0; i<levelCount; i++){
                    TreeNode curr = myQueue.Dequeue();
                    sum+=curr.val;
                    if(curr.left!=null){
                        myQueue.Enqueue(curr.left);
                    }
                    if(curr.right!=null){
                        myQueue.Enqueue(curr.right);
                    }
                }
                if(maxSum<sum){
                    maxSum = sum;
                    bestLevel = level;
                }
            }
            return bestLevel;
    }
}