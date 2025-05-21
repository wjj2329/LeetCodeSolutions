public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        SortedDictionary<int, int>myMap = new SortedDictionary<int, int>();
        foreach(int i in nums){
            if(!myMap.ContainsKey(i)){
                myMap.Add(i, 0);
            }
            myMap[i]+=1;
        }
        int[][]myArr= new int[nums.Length/3][];
        int first = 0;
        int second = 0;
        myArr[0]=new int[3];
        foreach(int s in myMap.Keys){
            for(int i = 0; i<myMap[s]; i++){
                 if(second ==3){
                    first++;
                    second=0;
                    myArr[first]=new int[3];
                }
                myArr[first][second]=s;
                second++;
                if(second ==3){
                if(myArr[first][2]-myArr[first][0]>k){
                        return new int[0][];
                    }          
                }
            }
        }
        return myArr;

    }
}