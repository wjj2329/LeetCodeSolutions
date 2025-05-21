public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int>mySet = new HashSet<int>();
        foreach(int s in nums){
            if(mySet.Contains(s)){
                return true;
            }
            mySet.Add(s);
        }
        return false;
    }
}