public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int[]temp = new int[nums.Length+1];
        for(int i =0; i<nums.Length; i++){
            if(nums[i]<temp.Length&&nums[i]>0){
                Console.WriteLine(nums[i]);
                temp[nums[i]]=1;
            }
        }
        for(int i =1; i<temp.Length; i++){
            if(temp[i]==0){
                return i;
            }
        }
        return temp.Length;
    }
}