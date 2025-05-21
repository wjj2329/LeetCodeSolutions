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
    public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete) {
        IList<TreeNode>nodes = new List<TreeNode>();
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        HashSet<int>delete = new HashSet<int>();
        foreach(int c in to_delete){
            delete.Add(c);
        }
        if(!delete.Contains(root.val)){
            nodes.Add(root);
        }

        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            int size = myQueue.Count;
            for(int i = 0; i<size; i++){
                TreeNode curr = myQueue.Dequeue();
                Console.WriteLine(curr.val);
                if(curr.left!= null){
                    myQueue.Enqueue(curr.left);
                    if(delete.Contains(curr.left.val)){
                        curr.left= null;
                    }
                }
                if(curr.right!=null){
                    myQueue.Enqueue(curr.right);
                    if(delete.Contains(curr.right.val)){
                        curr.right= null;
                    }
                }
                if(delete.Contains(curr.val)){
                    if(curr.left!=null){
                        nodes.Add(curr.left);
                    }
                    if(curr.right!=null){
                        nodes.Add(curr.right);
                    }
                }
            }
        }
        return nodes;
    }
}