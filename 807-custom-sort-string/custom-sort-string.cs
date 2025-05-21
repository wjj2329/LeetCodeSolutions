public class Solution {
    public string CustomSortString(string order, string s) {
        Dictionary<char, int>countingWord = new Dictionary<char, int>();
        foreach(char c in s){
            if(!countingWord.ContainsKey(c)){
                countingWord.Add(c, 0);
            }
            countingWord[c]++;
        }
        StringBuilder newWord = new StringBuilder();
        foreach(char c in order){
            if(countingWord.ContainsKey(c)){
                for(int i = 0; i<countingWord[c]; i++){
                    newWord.Append(c);
                }
                countingWord.Remove(c);
            }
        }
        foreach(char c in countingWord.Keys){
            for(int i = 0; i<countingWord[c]; i++){
                    newWord.Append(c);
                }
        }
        return newWord.ToString();
    }
}