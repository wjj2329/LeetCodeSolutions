public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int>myMap = new Dictionary<int, int>();
        int maxSize = nums.Length/2 + 1;
        foreach (int s in nums){
            if(!myMap.ContainsKey(s)){
                myMap.Add(s, 0);
            }
            myMap[s]+=1;
            if(myMap[s]==maxSize){
               return s;
            }
        }
        return -1;
    }
}