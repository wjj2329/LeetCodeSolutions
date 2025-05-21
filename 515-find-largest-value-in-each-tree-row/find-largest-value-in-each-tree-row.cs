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
    public IList<int> LargestValues(TreeNode root) {
        IList<int>myList = new List<int>();
        if(root==null){
            return myList;
        }
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            int level = myQueue.Count;
            int max = -2147483648;
            for(int i =0; i<level; i++){
                TreeNode curr = myQueue.Dequeue();
                if(curr.left!= null){
                    myQueue.Enqueue(curr.left);
                }
                if(curr.right!=null){
                    myQueue.Enqueue(curr.right);
                }
                max = Math.Max(max, curr.val);
            }
            myList.Add(max);
            
        }
        return myList;
    }
}