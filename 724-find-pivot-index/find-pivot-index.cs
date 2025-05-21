public class Solution {
    public int PivotIndex(int[] nums) {
        int left=0; 
        int right = nums.Sum();
        for(int i =0; i<nums.Length; i++){
            if(i!=0){
                left+=nums[i-1];
            }
            right-=nums[i];
            if(left == right){
                return i;
            }
        }
        
        return -1;
    }
}