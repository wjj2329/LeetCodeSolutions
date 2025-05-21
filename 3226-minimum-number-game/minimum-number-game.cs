public class Solution {
    public int findSmallest(int[]myArr){
        int min =101;
        int index = -1;
        for(int i=0; i<myArr.Length; i++){
            if(min>myArr[i]){
                min = myArr[i];
                index = i;
            }
        }
        myArr[index]=101;
        return min;
    }
    public int[] NumberGame(int[] nums) {
        int[]newOne = new int[nums.Length];
        for(int i =0; i<newOne.Length; i+=2){
            int smallest = findSmallest(nums);
            int secondSmallest = findSmallest(nums);
            newOne[i]=secondSmallest; 
            newOne[i+1] = smallest;
        }
        return newOne;
    }
}