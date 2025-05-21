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
public class FindElements {

    TreeNode root;
    public FindElements(TreeNode root) {
        this.root = root;
        if(root == null){
            return;
        }
        root.val = 0;
        Queue<TreeNode>myQueue = new Queue<TreeNode>();
        myQueue.Enqueue(root);
        while(myQueue.Count>0){
            TreeNode curr = myQueue.Dequeue();
            if(curr.left != null){
                curr.left.val = curr.val*2+1;
                myQueue.Enqueue(curr.left);
            }
            if(curr.right!=null){
                curr.right.val = curr.val*2+2;
                myQueue.Enqueue(curr.right);
            }
        }
    }
    
    public bool Rec(int target, TreeNode curr){
        if(curr == null){
            return false;
        }
        if(curr.val == target){
            return true;
        }
        return Rec(target, curr.left)||Rec(target, curr.right);
    }
    public bool Find(int target) {
        return Rec(target, root);
    }
}

/**
 * Your FindElements object will be instantiated and called as such:
 * FindElements obj = new FindElements(root);
 * bool param_1 = obj.Find(target);
 */