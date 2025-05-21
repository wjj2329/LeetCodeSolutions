public class Solution {
    public int MaxLengthBetweenEqualCharacters(string s) {
        if(s == null){
            return -1;
        }
        Dictionary<char, List<int>>myDict= new Dictionary<char, List<int>>();
        for(int i = 0; i<s.Length; i++){
            if(!myDict.ContainsKey(s[i])){
                myDict.Add(s[i], new List<int>());
            }
            myDict[s[i]].Add(i);
        }
        int biggest = -1;
        foreach(char c in myDict.Keys){
            if(myDict[c].Count>1){
                int difference = myDict[c][myDict[c].Count-1]-myDict[c][0];
                if(difference>biggest){
                    biggest = difference-1;
                }
            }
        }
        return biggest;
    }
}