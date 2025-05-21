public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int size = 0; 
        if(strs.Count()>0 ){
            size = strs[0].Count();
        }
        for(int i = 0; i<size; i++){
            char c = strs[0][i];
            foreach (string s in strs){
                if(i>=s.Count()||s[i]!=c){
                    return strs[0].Substring(0, i);
                }
            }
        }
        return strs[0]; 
    }
}