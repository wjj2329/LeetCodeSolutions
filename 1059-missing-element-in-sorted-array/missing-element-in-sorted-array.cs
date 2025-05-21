public class Solution {
    public int MissingElement(int[] nums, int k) {
        int[]counting = new int[nums[nums.Length-1]+1];
        for(int i =0; i<nums.Length; i++){
            counting[nums[i]]=1;
        }
        int index = nums[0];
        while(k>0 &&index<counting.Length-1){
            index++;
            if(counting[index]==0){
                k--;
            }
        }
        return index+k;
    }
}