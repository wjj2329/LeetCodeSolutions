
public class Solution {
    private int TimeToMin(string s){
        var split = s.Split(":");
        return int.Parse(split[0])*60+int.Parse(split[1]);
    }
    public IList<string> AlertNames(string[] keyName, string[] keyTime) {
        SortedSet<string>result = new SortedSet<string>();
        Dictionary<string, int[]>lookup = new Dictionary<string, int[]>();
        for(int i = 0; i<keyName.Length; i++){
            if(!lookup.ContainsKey(keyName[i])){
                lookup.Add(keyName[i], new int[24*60]);
            }
            int start = TimeToMin(keyTime[i]);
            for(int m =0; m<=60; m++){
                lookup[keyName[i]][start]++;
                if(lookup[keyName[i]][start]>=3){//can optimize this to not do this if set contains val already
                    result.Add(keyName[i]);
                    break;
                }
                start++;//handle wrap around
                if(start==24*60){
                    break;
                }
            }
        }
        return result.ToList();
    }
}