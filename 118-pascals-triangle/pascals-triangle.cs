public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> myList = new List<IList<int>>();
        List<int>temp = new List<int>();
        temp.Add(1);
        myList.Add(temp);
        if(numRows ==1){
            return myList;
        }
        temp = new List<int>();
        temp.Add(1);
        temp.Add(1);
        myList.Add(temp);
        if(numRows == 2){
            return myList;
        }
        numRows-=2;
        for(int i =0; i<numRows; i++){
            temp = new List<int>();
            temp.Add(1);
            var prev = myList[myList.Count-1];
            for(int x = 0; x<prev.Count-1; x++){
                temp.Add(prev[x]+prev[x+1]);
            }
            temp.Add(1);
            myList.Add(temp);
        }
        return myList;
    }
}