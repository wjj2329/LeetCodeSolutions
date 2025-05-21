public class Solution {

    Dictionary<int, List<int>>myMap = new Dictionary<int, List<int>>();
    Random rand = new Random();
    public Solution(int[] nums) {
        myMap = new Dictionary<int, List<int>>();
        for(int i =0; i<nums.Length; i++){
            if(!myMap.ContainsKey(nums[i])){
                myMap.Add(nums[i], new List<int>());
            }
            myMap[nums[i]].Add(i);
        }
    }
    
    public int Pick(int target) {
        int index = rand.Next(myMap[target].Count);
        return myMap[target][index];
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int param_1 = obj.Pick(target);
 */