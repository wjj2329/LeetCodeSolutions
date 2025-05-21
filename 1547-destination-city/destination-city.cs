public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string>group1 = new HashSet<string>();
        HashSet<string>group2 = new HashSet<string>();
        foreach(IList<string>list in paths){
            group1.Add(list[0]);
            group2.Add(list[1]);
        }
        foreach(string s in group2){
            if(!group1.Contains(s)){
                return s;
            }
        }
        return null;
    }
}