public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0){
            return false;
        }
        string s = x.ToString();
        for(int f = 0; f<s.Length/2; f++){
            if(s[f]!=s[s.Length-1-f]){
                return false;
            }
        }
        return true;
    }
}