public class SpecialComparer : IComparer<int>
{
    public int Compare(int d1, int d2)
    {      
        if (d1 == d2)
            return 0;
        return d2-d1;
    }
}
public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        SortedDictionary<int, int>countDict = new SortedDictionary<int, int>(new SpecialComparer());
        for (int i = 0; i<k; i++){
            if(!countDict.ContainsKey(nums[i])){
                countDict[nums[i]]=0;
            }
            countDict[nums[i]]++;
        }
        int[]result = new int[nums.Length-k+1];
        for(int i =k; i<nums.Length; i++ ){
            int biggest = countDict.Keys.First();
            result[i-k] = biggest;
            int removeVal = nums[i-k];
            countDict[removeVal]--;
            if(countDict[removeVal]==0){
                countDict.Remove(removeVal);
            }
            int addVal = nums[i];
            if(!countDict.ContainsKey(addVal)){
                countDict[addVal]=0;
            }
            countDict[addVal]++;
        }
        result[result.Length-1] = countDict.Keys.First();
        return result;
    }
}