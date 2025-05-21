public class Solution {
    public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill) {
        Dictionary<int, List<int>>myMap = new Dictionary<int, List<int>>();
        for(int i =0; i<pid.Count; i++){
            var child = pid[i];
            var parent = ppid[i];
            if(!myMap.ContainsKey(parent)){
                myMap.Add(parent, new List<int>());
            }
            myMap[parent].Add(child);
        }
        List<int>kills = new List<int>();
        Queue<int>proc = new Queue<int>();
        proc.Enqueue(kill);
        while(proc.Count>0){
            int curr = proc.Dequeue();
            kills.Add(curr);
            if(myMap.ContainsKey(curr)){
            foreach(int child in myMap[curr]){
                proc.Enqueue(child);
            }
            }
        }
        return kills;
    }
}