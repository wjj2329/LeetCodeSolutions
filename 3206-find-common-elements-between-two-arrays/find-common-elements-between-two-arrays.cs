public class Solution {
    public int[] FindIntersectionValues(int[] nums1, int[] nums2) {
        HashSet<int>mySet1 = new HashSet<int>();
        HashSet<int>mySet2 = new HashSet<int>();
        foreach(int i in nums1){
            mySet1.Add(i);
        }
        foreach(int i in nums2){
            mySet2.Add(i);
        }
        int[]result = new int[2];
        int count = 0;
        foreach(int i in nums1){
            if(mySet2.Contains(i)){
                count++;
            }
        }
        result[0]=count;
        count=0;
        foreach(int i in nums2){
            if(mySet1.Contains(i)){
                count++;
            }
        }
        result[1]=count;
        return result;
    }
}