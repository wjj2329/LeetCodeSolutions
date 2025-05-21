public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[]pair = new int[2];
        int duplicated =-1;
        HashSet<int>mySet = new HashSet<int>();
        foreach(int i in nums){
            if(mySet.Contains(i)){
                duplicated = i;
            }
            mySet.Add(i);
        }
        int missing = -1; 
        for(int i =0; i<nums.Length; i++){
            if(!mySet.Contains(i+1)){
                missing = i+1;
                break;
            }
        }
        pair[0]=duplicated;
        pair[1]=missing;
        return pair;
        
    }
}