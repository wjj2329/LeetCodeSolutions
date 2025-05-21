public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        HashSet<int>mySet = new HashSet<int>();
        foreach(int i in nums){
            mySet.Add(i);
        }
        while(mySet.Contains(original)){
            original*=2;
        }
        return original;
    }
}