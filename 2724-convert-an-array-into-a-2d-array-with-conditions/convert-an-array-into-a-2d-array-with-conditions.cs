public class Solution {
    public IList<IList<int>> FindMatrix(int[] nums) {
        Dictionary<int, int>myDict = new Dictionary<int, int>();
        foreach(int s in nums){
            if(!myDict.ContainsKey(s)){
                myDict.Add(s, 0);
            }
            myDict[s]+=1;
        }
        List<IList<int>>myList = new List<IList<int>>();
        while(myDict.Keys.Count>0){
            List<int>temp = new List<int>();
            foreach(int key in myDict.Keys){
                temp.Add(key);
                myDict[key]-=1;
                if(myDict[key]==0){
                    myDict.Remove(key);
                }
            }
            myList.Add(temp);
        }
        return myList;
    }
}