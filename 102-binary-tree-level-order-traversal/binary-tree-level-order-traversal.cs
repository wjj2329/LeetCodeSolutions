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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>>myList = new List<IList<int>>();
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        if(root!=null){
        myQueue.Enqueue(root);
        }
        while(myQueue.Count>0){
            int row = myQueue.Count;
            IList<int>temp = new List<int>();
            for(int i = 0; i<row; i++){
                TreeNode curr = myQueue.Dequeue();
                if(curr.left!=null){
                    myQueue.Enqueue(curr.left);
                }
                if(curr.right!=null){
                    myQueue.Enqueue(curr.right);
                }
                
                    temp.Add(curr.val);
            }
            myList.Add(temp);          
        }
        return myList;
            }
}