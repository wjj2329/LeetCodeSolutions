public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int, int>myMap = new Dictionary<int, int>();
        foreach(int i in arr){
            if(!myMap.ContainsKey(i)){
                myMap.Add(i, 0);
            }
            myMap[i]+=1;
        }
        HashSet<int>exists = new HashSet<int>();
        foreach(int s in myMap.Values){
            if(exists.Contains(s)){
                return false;
            }
            exists.Add(s);
        }
        return true;
    }
}