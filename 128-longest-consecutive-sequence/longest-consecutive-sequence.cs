public class Solution {
    public int LongestConsecutive(int[] nums) {
        SortedSet<int>mySet = new SortedSet<int>();
        foreach(int s in nums){
            mySet.Add(s);
        }
        int maxCount = 0; 
        HashSet<int>visited = new HashSet<int>();
        foreach(int s in mySet){
            int count=0;
            int current = s;
            if(!visited.Contains(current)){
            while(mySet.Contains(current)){
                visited.Add(current);
                current++;
                count++;
            }
            }
            maxCount = Math.Max(count, maxCount);
        }
        return maxCount;
    }
}