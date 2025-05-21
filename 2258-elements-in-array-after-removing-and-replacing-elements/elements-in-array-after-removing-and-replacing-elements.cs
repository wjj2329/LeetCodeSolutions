public class Solution {
    public int[] ElementInNums(int[] nums, int[][] queries) {
        List<List<int>>lookup = new List<List<int>>();
        List<int>myList = new List<int>(nums);
        while(myList.Count>0){
            lookup.Add(myList.ToList()); //clone
            myList.RemoveAt(0);
        }
        for(int i = 0; i<nums.Length; i++){
            lookup.Add(myList.ToList()); //clone
            myList.Add(nums[i]);
        }
        int[]result = new int[queries.Length];
        for(int i = 0; i<queries.Length; i++){
            if(lookup[queries[i][0]%lookup.Count].Count>queries[i][1]){
            result[i]=lookup[queries[i][0]%lookup.Count][queries[i][1]];
            }else{
                result[i]=-1;
            }
        }
        return result;
    }
}