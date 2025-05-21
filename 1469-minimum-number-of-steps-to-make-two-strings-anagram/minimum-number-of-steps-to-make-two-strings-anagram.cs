public class Solution {
    public void ConvertWordDict(string s , Dictionary<char, int>dic){
        foreach(char c in s){
            if(!dic.ContainsKey(c)){
                dic.Add(c, 0);
            }
            dic[c]+=1;
        }
    }
    public int MinSteps(string s, string t) {
        Dictionary<char, int>word1 = new Dictionary<char, int>();
        Dictionary<char, int>word2 = new Dictionary<char, int>();
        ConvertWordDict(s, word1);
        ConvertWordDict(t, word2);
        int total = 0;
        foreach(char c in word2.Keys){
            if(word1.ContainsKey(c)){
                if(word2[c]>word1[c])
                total+=(word2[c]-word1[c]);
            }else{
                total+=word2[c];
            }
        }
        return total; 
    }
}