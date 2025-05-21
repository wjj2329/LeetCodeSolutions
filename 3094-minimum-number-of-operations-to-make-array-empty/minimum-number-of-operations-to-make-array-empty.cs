public class Solution {
    public int MinOperations(int[] nums) {
        Dictionary<int, int>myMap = new Dictionary<int, int>();
        foreach(int s in nums){
            if(!myMap.ContainsKey(s)){
                myMap.Add(s, 0);
            }
            myMap[s]+=1;
        }
        int operations = 0;
        foreach(int s in myMap.Keys){
            if(myMap[s]==1){
                return -1;
            }
            while(myMap[s]>4){
                myMap[s]-=3;
                operations++;
            }
            if(myMap[s]==3){
                myMap[s]-=3;
                operations++;
            }
            if(myMap[s]==4){
                myMap[s]-=4;
                operations+=2;
            }
            if(myMap[s]==2){
                myMap[s]-=2;
                operations++;
            }
        }
        return operations;
    }
}