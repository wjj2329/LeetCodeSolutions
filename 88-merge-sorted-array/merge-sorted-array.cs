public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        SortedDictionary<int, int>myMap = new SortedDictionary<int, int>();
        for(int i = 0; i<m; i++){
            if(!myMap.ContainsKey(nums1[i])){
                myMap[nums1[i]]=0;
            }
            myMap[nums1[i]]++;
        }
        for(int i = 0; i<n; i++){
            if(!myMap.ContainsKey(nums2[i])){
                myMap[nums2[i]]=0;
            }
            myMap[nums2[i]]++;
        }
        int index = 0;
        foreach(int key in myMap.Keys){
            for(int i =0; i<myMap[key]; i++){
                nums1[index]=key;
                index++;
            }
        }
    }
}