
public class Solution {
    public string FrequencySort(string s) {
        Dictionary<char, int>myMap = new Dictionary<char, int>();
        foreach(char c in s){
            if(!myMap.ContainsKey(c)){
                myMap[c]=0;
            }
            myMap[c]++;
        }
        var sorted = myMap.OrderByDescending(x =>x.Value);
        StringBuilder sb = new StringBuilder();
        foreach(var kvp in sorted){
            for(int i =0; i<kvp.Value; i++){
                sb.Append(kvp.Key);
            }
        }
        return sb.ToString();

    }
}