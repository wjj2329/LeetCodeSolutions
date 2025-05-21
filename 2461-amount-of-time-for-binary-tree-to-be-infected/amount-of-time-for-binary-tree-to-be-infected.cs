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
    TreeNode start;
    public void Traverse(TreeNode curr, int look, Dictionary<TreeNode, TreeNode>myDict){
        if(curr.val == look){
            start = curr;
        }
        if(curr.right!=null){
            myDict.Add(curr.right, curr);
            Traverse(curr.right, look, myDict);
        }
        if(curr.left!=null){
            myDict.Add(curr.left, curr);
            Traverse(curr.left, look, myDict);
        }
    }
    public int AmountOfTime(TreeNode root, int s) {
        Dictionary<TreeNode, TreeNode>myMap = new Dictionary<TreeNode, TreeNode>();
        Traverse(root, s, myMap);
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(start);
        int rounds = -1;
        while(myQueue.Count>0){
            int roundCount = myQueue.Count;
            rounds++;
            for(int i =0; i<roundCount; i++){
                TreeNode curr = myQueue.Dequeue();
                if(curr.left !=null&&curr.left.val!=-1){
                    myQueue.Enqueue(curr.left);
                }
                if(curr.right!=null&&curr.right.val!=-1){
                    myQueue.Enqueue(curr.right);
                }
                if(myMap.ContainsKey(curr)&&myMap[curr].val!=-1){
                    myQueue.Enqueue(myMap[curr]);
                }
                
                curr.val = -1;
            }
        }
        return rounds;
    }
}