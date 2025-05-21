public class Solution {

    public bool CanJump(int[] nums) {
        Stack<int>stack = new Stack<int>();
        HashSet<int>visited = new HashSet<int>();
        stack.Push(0);
        while(stack.Count>0){
            int curr = stack.Pop();
            if(visited.Contains(curr)){
                continue;
            }
            if(curr>=nums.Length-1){
                return true;
            }
            visited.Add(curr);
            for(int i =curr+1; i<=curr+nums[curr]; i++){
                if(!visited.Contains(i))
                    stack.Push(i);
            }
        }
        return false;
    }
}