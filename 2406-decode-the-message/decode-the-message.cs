public class Solution {
    public string DecodeMessage(string key, string message) {
        Dictionary<char, char>myDict = new Dictionary<char, char>();
        int letter = 'a';
        for(int i =0; i<key.Length; i++){
            if(!myDict.ContainsKey(key[i])&&key[i]!=' '){
                myDict.Add(key[i], (char)letter);
                letter++;
            }
            if(letter>(int)'z'){
                break;
            }
        }
        StringBuilder result = new StringBuilder();
        foreach (char c in message){
            if(c ==' '){
                result.Append(' ');
            }else{
            result.Append(myDict[c]);
            }
        }
        return result.ToString();
    }
}