public class Solution {
    public bool IsMonotonic(int[] nums) {
        if(nums.Length ==1|| nums.Length ==2){
            return true;
        }
        int index = 0;
        while(index<nums.Length-1&&nums[index]==nums[index+1]){
            index++;
        }
        if(index == nums.Length-1){
            return true;
        }
        bool asc = false;
        if(nums[index]<nums[index+1]){
            asc = true;
        }
        while(index<nums.Length-1){
            if(asc){
                if(nums[index]>nums[index+1]){
                    return false;
                }
            }else{
                if(nums[index]<nums[index+1]){
                    return false;
                }
            }
            index++;
        }
        return true;
    }
}