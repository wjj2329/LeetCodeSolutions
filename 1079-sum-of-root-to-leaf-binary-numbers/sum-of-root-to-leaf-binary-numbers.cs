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
    public int StringToInt(string s){
        int log2 = 1;
        int count = 0;
        for(int i = s.Length-1; i>=0; i--){
            count+=int.Parse(s[i].ToString())*log2;
            log2*=2;
        }
        return count;
    }
    public int Traverse(TreeNode curr, StringBuilder sb){
        if(curr == null){
            return 0;
        }
        sb.Append(curr.val);
        if(curr.left == null && curr.right == null)
        {
            var result= StringToInt(sb.ToString());
            sb.Length--;
            return result;
        }
        var c = Traverse(curr.left, sb)+Traverse(curr.right, sb);
        sb.Length--;
        return c;
    }
    public int SumRootToLeaf(TreeNode root) {
        return Traverse(root, new StringBuilder());
    }
}