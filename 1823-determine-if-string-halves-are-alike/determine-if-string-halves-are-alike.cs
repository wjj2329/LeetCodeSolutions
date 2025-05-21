public class Solution {
    public bool isVowel(char c ){
        if(c =='a'||c=='A'||c =='e'||c=='E'||c=='i'||c=='I'||c=='o'||c=='O'||c=='u'||c=='U'){
            return true;
        }
        return false;
    }
    public bool HalvesAreAlike(string s) {
        int count1 = 0; 
        int count2 = 0; 
        for(int i = 0; i<s.Length/2; i++){
            if(isVowel(s[i])){
                count1++;
            }
        }
        for(int i = s.Length/2; i<s.Length; i++){
            if(isVowel(s[i])){
                count2++;
            }
        }
        return count1==count2;
    }
}