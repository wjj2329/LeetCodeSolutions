public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        List<IList<int>>myList = new List<IList<int>>();
        SortedDictionary<int, int>losers = new SortedDictionary<int, int>();
        SortedSet<int>winners = new SortedSet<int>();
        foreach(int[]s in matches){
            winners.Add(s[0]);
            if(!losers.ContainsKey(s[1])){
                losers.Add(s[1], 0);
            }
            losers[s[1]]++;
        }
        List<int>temp = new List<int>();
        myList.Add(temp);
        List<int>c = new List<int>();
        myList.Add(c);
        foreach(int s in winners){
            if(!losers.ContainsKey(s)){
                myList[0].Add(s);
            }
        }
        foreach(int s in losers.Keys){
            if(losers[s]==1){
                myList[1].Add(s);
            }
        }

        return myList;
    }
}