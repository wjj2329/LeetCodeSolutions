public class Solution {
    public bool IsPalindrome(string word){
        for(int i=0; i<word.Length/2; i++){
            if(word[i]!=word[word.Length-1-i]){
                return false;
            }     
        }
        return true;
    }
    public string FirstPalindrome(string[] words) {
        foreach(string s in words){
            if(IsPalindrome(s)){
                return s;
            }
        }
        return "";
    }
}