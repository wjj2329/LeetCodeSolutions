public class Solution {
    public int MakeConnected(int n, int[][] connections) {
if(connections.Count()<n-1){
            return -1;
        }
        Dictionary<int, List<int>>myMap = new Dictionary<int, List<int>>();
        for(int i =0; i<n; i++){
            myMap[i] = new List<int>();
        }
        foreach(int[] connection in connections){
            myMap[connection[0]].Add(connection[1]);
            myMap[connection[1]].Add(connection[0]);
        }
        int count = -1;
        while(myMap.Keys.Count>0){
            count++;
            int first = myMap.Keys.First();
            HashSet<int>children = new HashSet<int>();
            children.Add(first);
            while(children.Count>0){
                int current = children.First();
                if(myMap.ContainsKey(current)){
                foreach(int c  in myMap[current]){
                    children.Add(c);
                }
                }
                myMap.Remove(current);
                children.Remove(current);
            }

        }
        return count;
            }
}