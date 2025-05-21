public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int>myMap = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            myMap[nums[i]]=i;
        }
        for(int i =0; i < nums.Length; i++){
            if(myMap.ContainsKey(target - nums[i]) && i != myMap[target - nums[i]]){
                int[] myArr = new int[2];
                myArr[0] = i;
                myArr[1] = myMap[target-nums[i]];
                return myArr;
            }
        }
        return null;
    }
}