public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = 0; 
        int right = nums.Length-1;
        int found = -1;
        List<int>result = new List<int>();
        while(left<=right){
            int index = left +(right-left)/2;
            if(nums[index]==target){
                found = index;
                break;
            }
            if(nums[index]>target){
                right = index-1;
            }else{
                left = index+1;
            }
        }
        if(found == -1){
            result.Add(-1);
            result.Add(-1);
            return result.ToArray();
        }
        while(found-1>=0&& nums[found-1]==target){
            found--;
        }
        result.Add(found);
        while(found<nums.Length&&nums[found]==target){
            found++;
        }
        result.Add(found-1);
        return result.ToArray();
    }
}