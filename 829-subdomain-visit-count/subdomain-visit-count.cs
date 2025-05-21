public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int>countMap = new Dictionary<string, int>();
        StringBuilder key = new StringBuilder();
        foreach(string s in cpdomains){
            var parts = s.Split(' ');
            var temp = parts[1].Split('.');
            key.Clear();
            for (int i = temp.Length-1; i>=0; i--){
                key.Insert(0,temp[i]);
                if(!countMap.ContainsKey(key.ToString())){
                    countMap.Add(key.ToString(), 0);
                }
                countMap[key.ToString()]+=int.Parse(parts[0]);
                key.Insert(0,".");
            }
        }
        List<string>result = new List<string>();
        foreach(string s in countMap.Keys){
            result.Add(countMap[s]+" "+s);
        }
        return result;
        
    }
}