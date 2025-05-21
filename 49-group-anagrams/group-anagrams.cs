public class Solution {
    public string StringToArr(string s){
        SortedDictionary<char, int>count = new SortedDictionary<char, int>();
        foreach(char c in s){
            if(!count.ContainsKey(c))
                count.Add(c, 0);
            count[c]++;    
        }
        StringBuilder sb = new StringBuilder();
        foreach(char c in count.Keys){
            sb.Append(c);
            sb.Append(count[c]);
        }
        return sb.ToString();
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>>myMap = new Dictionary<string, List<string>>();
        foreach(string s in strs){
            string key = StringToArr(s);
            if(!myMap.ContainsKey(key)){
                myMap.Add(key, new List<string>());
            }
            myMap[key].Add(s);
        }
        List<IList<string>>myL = new List<IList<string>>();
        foreach(List<string> list in myMap.Values){
            myL.Add(list);
        }
        return myL;
    }
}