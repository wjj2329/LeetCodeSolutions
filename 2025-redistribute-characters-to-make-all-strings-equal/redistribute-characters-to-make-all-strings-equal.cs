public class Solution {
    public bool MakeEqual(string[] words) {
        if(words==null){
            return true;
        }
        Dictionary<char, int>myDict =  new Dictionary<char, int>();
        foreach(string word in words){
            foreach(char c in word){
                if(!myDict.ContainsKey(c)){
                    myDict.Add(c, 0);
                }
                myDict[c]+=1;
            }
        }
        int count= words.Length; 
        foreach(int c in myDict.Values){
            if(c%count!=0){
                return false;
            }
        }
        return true;
    }
}