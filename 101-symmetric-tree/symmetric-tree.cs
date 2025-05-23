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
    
    public bool IsSymmetric(TreeNode root) {
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            int count = myQueue.Count;
            List<TreeNode>myList = new List<TreeNode>();
            bool allNull = true;
            for(int i = 0; i< count; i++){
                var c = myQueue.Dequeue();
                myList.Add(c);
                if(c == null){
                    myQueue.Enqueue(null);
                    myQueue.Enqueue(null);
                }else{
                    myQueue.Enqueue(c.left);
                    myQueue.Enqueue(c.right);
                    allNull = false;
                }
            }
            for(int i = 0; i<myList.Count; i++){
                if(myList[i] == null && myList[myList.Count-1-i] != null){
                    return false;
                }
                if(myList[i] != null && myList[myList.Count-1-i] == null){
                    return false;
                }
                if(myList[i] != null && myList[myList.Count-1-i] != null){
                    if(myList[i].val!=myList[myList.Count-1-i].val){
                        return false;
                    }
                }
            }
            if(allNull){
                return true;
            }
        }
        return true;
    }
}