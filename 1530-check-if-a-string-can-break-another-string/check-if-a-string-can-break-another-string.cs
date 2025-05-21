public class Solution {
    public string Sort(string word){
        SortedDictionary<char, int>countDict = new SortedDictionary<char, int>();
        foreach(char c in word){
            countDict.TryAdd(c, 0);
            countDict[c]+=1;
        }
        StringBuilder sb = new StringBuilder();
        foreach(char c in countDict.Keys){
            for(int i = 0; i<countDict[c]; i++){
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
    public bool CheckIfCanBreak(string s1, string s2) {
        s1 = Sort(s1);
        s2 = Sort(s2);
        int index = 0;
        while(index<s1.Length && s1[index]==s2[index]){
            index++;
        }
        bool order = s1[index]>s2[index]?false:true;
        for(; index<s1.Length; index++){
            if(order){
                if(s1[index]>s2[index]){
                    return false;
                }
            }else{
                if(s2[index]>s1[index]){
                    return false;
                }
            }
        }
        return true;
    }
}