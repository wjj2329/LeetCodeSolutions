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
    public void Traverse(TreeNode curr, List<int>myList){
        Stack<TreeNode>myQueue = new Stack<TreeNode>();
        myQueue.Push(curr); 
        while(myQueue.Count>0){
            TreeNode temp= myQueue.Pop();
            if(temp.left == null && temp.right == null){
                myList.Add(temp.val);
            }
            if(temp.left!=null){
                myQueue.Push(temp.left);
            }
            if(temp.right!=null){
                myQueue.Push(temp.right);
            }
        }
    }
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int>myList1 = new List<int>();
        List<int>myList2 = new List<int>();
        Traverse(root1, myList1);
        Traverse(root2, myList2);
        if(myList1.Count != myList2.Count){
            return false;
        }
        for(int i =0; i<myList1.Count; i++){
            if(myList1[i]!=myList2[i]){
                Console.WriteLine(myList1[i]+" "+myList2[i]);
                return false;
            }
        }
        return true;

    }
}