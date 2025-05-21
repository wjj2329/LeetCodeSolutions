public class Solution {
    public int[] FindBuildings(int[] heights) {
        List<int>myList = new List<int>();
        int max = -1;
        for(int i = heights.Length-1; i>=0; i--){
            if(heights[i]>max){
                max = heights[i];
                myList.Add(i);
            }
        }
        int[]temp = new int[myList.Count];
        int size = myList.Count-1;
        for(int i = 0; i<temp.Length; i++){
            temp[size-i]=myList[i];
        }
        return temp;
    }
}