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
    public void SetUpDepths(TreeNode curr,  Dictionary<TreeNode, int>maxDepth,Dictionary<TreeNode, int>currDepth, Dictionary<int, TreeNode>lookUpDict , int level){
        if(curr == null){
            return;
        }
        lookUpDict.Add(curr.val, curr);
        currDepth.Add(curr, level);
        SetUpDepths(curr.left, maxDepth, currDepth, lookUpDict, level+1);
        SetUpDepths(curr.right, maxDepth, currDepth, lookUpDict, level+1);
        int max = level;
        if(curr.right!=null){
            max = Math.Max(maxDepth[curr.right], max);
        }
        if(curr.left!=null){
            max= Math.Max(maxDepth[curr.left], max);
        }
        maxDepth.Add(curr, max);
    }
    public void SetUpCousins(TreeNode root,  Dictionary<TreeNode, PriorityQueue<TreeNode, int>> cousins, Dictionary<TreeNode, int>maxDepth){
     Queue<TreeNode>myQueue = new Queue<TreeNode>();
     myQueue.Enqueue(root);
     while(myQueue.Count>0){
         int size = myQueue.Count;
         PriorityQueue<TreeNode, int>cous = new PriorityQueue<TreeNode, int>(Comparer<int>.Create((x, y) => y - x));
         for(int i =0; i<size; i++){
             TreeNode current = myQueue.Dequeue();
             if(current.left!=null){
                 myQueue.Enqueue(current.left);
             }
             if(current.right!=null){
                 myQueue.Enqueue(current.right);
             }
             cous.Enqueue(current, maxDepth[current] );
             cousins.Add(current, cous);
         }
     }
 }
 public int FindMax(PriorityQueue<TreeNode, int > cousins, TreeNode removed,  int valueOfRemoved ){
     int max = valueOfRemoved -1;
     TreeNode first = null;
     int firstVal = -1;
     TreeNode second = null;
     int secondVal = -1; 
     if(cousins.Count>0){
         cousins.TryDequeue(out first, out firstVal);
         if(first == removed && cousins.Count>0){
             cousins.TryDequeue(out second, out secondVal);
         }
     }
     if(first!=null){
         cousins.Enqueue(first, firstVal);
     }
     if(second!=null){
         cousins.Enqueue(second, secondVal);
     }
     if(first == null){
         return max;
     }
     if(first != removed){
         return Math.Max(firstVal, max);
     }
     if(second!= null){
         return Math.Max(secondVal, max);
     }
     return max;
 }
    public int[] TreeQueries(TreeNode root, int[] queries) {
        int [] result = new int[queries.Length];
        Dictionary<TreeNode, int>maxDepth = new Dictionary<TreeNode, int>();
        Dictionary<TreeNode, int>currDepth = new Dictionary<TreeNode, int>();
        Dictionary<int, TreeNode>lookUpDict = new Dictionary<int, TreeNode>();
        Dictionary<TreeNode, PriorityQueue<TreeNode, int>> cousins = new Dictionary<TreeNode, PriorityQueue<TreeNode, int>>();
        SetUpDepths(root, maxDepth, currDepth, lookUpDict , 0);
        SetUpCousins(root, cousins, maxDepth);
        for(int i =0; i<queries.Length; i++){
            TreeNode curr = lookUpDict[queries[i]];
            result[i]=FindMax(cousins[curr], curr, currDepth[curr]);
        }
        return result;
    }
}