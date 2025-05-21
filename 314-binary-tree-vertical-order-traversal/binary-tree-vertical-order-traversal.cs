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
 public class TreeNodeInfo{
     public int leftCount;
     public int rightCount;
     public int index; 
     public TreeNodeInfo(int leftCount, int rightCount){
         this.leftCount= leftCount;
         this.rightCount = rightCount;
         this.index = rightCount - leftCount;
     }
 }

public class Solution {
    int leftMost = 0; 
    int rightMost = 0; 
     public void Traverse(TreeNode curr, int left, int right, Dictionary<TreeNode, TreeNodeInfo>myDict){
     if(curr == null){
         return;
     }
     myDict.Add(curr, new TreeNodeInfo(left, right));
     leftMost = Math.Max(leftMost, left-right);
     rightMost = Math.Max(rightMost, right-left);
     Traverse(curr.left, left+1, right, myDict);
     Traverse(curr.right, left, right+1, myDict);
     }
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        List<IList<int>>myList = new List<IList<int>>();
        if(root== null){
            return myList;
        }
        Dictionary<TreeNode, TreeNodeInfo>myDict = new Dictionary<TreeNode, TreeNodeInfo>();
        Traverse(root, 0, 0, myDict);
        Console.WriteLine(leftMost);
        Console.WriteLine(rightMost);
        int listSize = leftMost+rightMost+1;
        Console.WriteLine(listSize);
        for(int i =0; i<listSize; i++){
            myList.Add(new List<int>());
        }
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            TreeNode curr = myQueue.Dequeue();
            if(curr.left!=null){
                myQueue.Enqueue(curr.left);
            }
            if(curr.right!=null){
                myQueue.Enqueue(curr.right);
            }
            myList[myDict[curr].index+leftMost].Add(curr.val);
        }
        return myList;
    }
}