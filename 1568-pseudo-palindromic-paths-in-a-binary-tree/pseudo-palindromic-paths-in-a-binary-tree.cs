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
    int count = 0;
    public void Traverse(TreeNode curr, Dictionary<int, int>path){
        if(curr == null){
            return;
        }
        if(!path.ContainsKey(curr.val)){
            path.Add(curr.val, 0);
        }
        path[curr.val]++;
        if(curr.left ==null &&curr.right==null){
            if(isPal(path)){
                count+=1;
            }
        }
        Traverse(curr.left, path);
        Traverse(curr.right, path);
        path[curr.val]--;
        if(path[curr.val]==0){
            path.Remove(curr.val);
        }
    }
    public bool isPal(Dictionary<int, int>countDict){       
        bool isOddSeen = false;
        foreach(int count in countDict.Values){
            if(count%2==1){
                if(!isOddSeen){
                    isOddSeen = !isOddSeen;
                }else{
                    return false;
                }
            }
        }
        return true;
    }
    public int PseudoPalindromicPaths (TreeNode root) {
        Traverse(root, new Dictionary<int, int>());        
        return count;
    }
}