public class Solution {
    public bool IsPathCrossing(string path) {
        HashSet<Tuple<int, int>>vistedPoints = new HashSet<Tuple<int, int>>();
        int first = 0; 
        int second = 0;
        Tuple<int, int>temp = new Tuple<int, int>(first, second);
        vistedPoints.Add(temp);
        foreach(char c in path){
            if(c == 'N'){
                first++;
            }
            if(c == 'S'){
                first--;
            }
            if(c == 'E'){
                second++;
            }
            if(c == 'W'){
                second--;
            }
            Tuple<int, int>pair = new Tuple<int, int>(first, second);
            if(vistedPoints.Contains(pair)){
                return true;
            }
            vistedPoints.Add(pair);
        }
        return false;
    }
}