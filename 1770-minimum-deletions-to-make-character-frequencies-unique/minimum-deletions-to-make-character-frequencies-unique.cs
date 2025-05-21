public class Solution {
    public int MinDeletions(string s) {
        int deletions = 0;
        Dictionary<int, int>myMap = new Dictionary<int, int>();
        foreach (char c in s){
            if(!myMap.ContainsKey(c)){
                myMap.Add(c, 0);
            }
            myMap[c]++;
        }
        HashSet<int>mySet = new HashSet<int>();
        foreach(int c in myMap.Values){
            int count = c;
            if(!mySet.Contains(count)){
                mySet.Add(count);
            }else{
                while(mySet.Contains(count)&&count>0){
                    deletions++;
                    count--;
                }
                if(count>0){
                    mySet.Add(count);
                }
            }
        }
        return deletions;
    }
}