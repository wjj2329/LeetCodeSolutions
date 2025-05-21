public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int start = 0; 
        int end = 0;
        int max = 0;
        HashSet<char>mySet= new HashSet<char>();
        while(end<s.Length){
            char curr = s[end];
            if(!mySet.Contains(curr)){
                mySet.Add(curr);
                max = Math.Max(max, mySet.Count);
                end++;
            }else{
                mySet.Remove(s[start]);
                start++;
            }
        }
        return max;
    }
}