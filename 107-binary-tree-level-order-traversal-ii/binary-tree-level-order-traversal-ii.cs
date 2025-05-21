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
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        IList<IList<int>>myList = new List<IList<int>>();
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        if(root!=null){
        myQueue.Enqueue(root);
        }
        while(myQueue.Count>0){
            int count = myQueue.Count;
            List<int> temp = new List<int>();
            for(int i = 0; i<count; i++){
                TreeNode node = myQueue.Dequeue();
                temp.Add(node.val); 
                if(node.left!=null){
                    myQueue.Enqueue(node.left);
                }
                if(node.right!=null){
                    myQueue.Enqueue(node.right);
                }               
            }
            myList.Insert(0,temp);
        }
        return myList;
    }
}