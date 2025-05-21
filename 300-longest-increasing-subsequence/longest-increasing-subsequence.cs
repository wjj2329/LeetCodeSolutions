public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[]dp = new int[nums.Length];
        for(int i =0; i<dp.Length; i++){
            dp[i]=1;
        }
        for(int i = 1; i<dp.Length; i++){
            for(int j = 0; j<i; j++){
                if(nums[i]>nums[j])
                    dp[i]= Math.Max(dp[i], dp[j]+1);
            }
        }
        int longest = 0;
        foreach (int c in dp) {
            longest = Math.Max(longest, c);
        }
        return longest;
    }
}